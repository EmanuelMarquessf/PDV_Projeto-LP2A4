using PDV.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    class OrderDAO
    {
        private Connection Con { get; set; }

        private SqlCommand Cmd { get; set; }

        public OrderDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }
        public void Insert(Order order)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO [Order] VALUES (@Pay_Form, @Id_Client, @Date_Order, @Amount_Order)";

            Cmd.Parameters.AddWithValue("@Pay_Form", order.PayForm);
            Cmd.Parameters.AddWithValue("@Id_Client", order.IdClient);
            Cmd.Parameters.AddWithValue("@Date_Order", order.Date);
            Cmd.Parameters.AddWithValue("@Amount_Order", order.Amount);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir pedido no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<Order> ListAllOrders()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "select Id_Order, Id_Client from [Order]";

            List<Order> listOfOrders = new List<Order>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Order order = new Order((int)rd["Id_Order"], (int)rd["Id_Client"]);
                    listOfOrders.Add(order);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar a leitura do banco. \n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return listOfOrders;
        }

    }
}
