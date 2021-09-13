using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WebApp.Core.Domain;
using WebApp.Core.Interfaces;

namespace WebApp.Infraestructure.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly string _connectionString;
        public ProductoRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }
        public IEnumerable<Producto> GetProductos()
        {
            List<Producto> list = new List<Producto>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT productoId,nombre,descripcion,valor FROM Producto";
                    con.Open();
                    using (SqlTransaction sqlTran = con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Transaction = sqlTran;
                            cmd.Connection = con;
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    list.Add(new Producto()
                                    {
                                        ProductoId = (sdr["productoId"] != null) ? int.Parse(sdr["productoId"].ToString()) : 0,
                                        Nombre = sdr["nombre"].ToString(),
                                        Descripcion = sdr["descripcion"].ToString(),
                                        Valor = (sdr["valor"] != null) ? decimal.Parse(sdr["valor"].ToString()) : 0,
                                    });
                                }
                            }
                            sqlTran.Commit();
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.ToString());
            }
            return list;
        }
    }
}
