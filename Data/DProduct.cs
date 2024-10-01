using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DProduct
    {

        public List<Product> listProduct()
        {
            // creando un objeto de connection
            SqlConnection conneection = new SqlConnection(DConnection.SQLconnectionDB);

            // abrimos la conexion
            conneection.Open();

            // creamos un objeto de command y usamos +para realizar la consulta
            SqlCommand command = new SqlCommand("listProducts", conneection);

            // specifiy procedure
            command.CommandType = CommandType.StoredProcedure;

            // create list new objet
            List<Product> listProduct = new List<Product>();

            // Ingresamos el nombre del que vamos a buscar


            // execute procedure
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                Product product = new Product();
                product.productid = Convert.ToInt32(reader["product_id"]);
                product.name = reader["name"].ToString();
                product.price = Convert.ToDecimal(reader["price"]);
                product.stock = Convert.ToInt32(reader["stock"]);
                product.active = Convert.ToInt32(reader["active"]);
                listProduct.Add(product);
            }

            conneection.Close();

            return listProduct;
        }
    }
}
