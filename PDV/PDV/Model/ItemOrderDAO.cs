using PDV.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    class ItemOrderDAO
    {
        private Connection Con { get; set; }

        private SqlCommand Cmd { get; set; }

        public ItemOrderDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }

        public void Insert(ItemOrder itemOrder)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Item_Order VALUES((SELECT MAX(Id_Order) FROM[Order]), @Id_Product, @Quant_Item)";
            Cmd.CommandText = @"UPDATE Product SET Quant_Product = Quant_Product - @Quant_Item WHERE Id_Product = @Id_Product";
            Cmd.Parameters.AddWithValue("@Id_Product", itemOrder.IdProduct); 
            Cmd.Parameters.AddWithValue("@Quant_Item", itemOrder.Quant);


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

        public void Update(ItemOrder itemOrder)
        {
            Cmd.CommandText = @"UPDATE Product SET Quant_Product = Quant_Product - @Quant_Product WHERE Id_Product = @Id_Product";
            Cmd.Parameters.AddWithValue("@Id_Product", itemOrder.IdProduct);
            Cmd.Parameters.AddWithValue("@Quant_Item", itemOrder.Quant);

            try
            {
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar cliente no banco.\n" + err.Message);
            }
            finally
            {
            }
        }


    }
}
