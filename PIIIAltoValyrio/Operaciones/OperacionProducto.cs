using PIIIAltoValyrio.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace PIIIAltoValyrio.Operaciones
{
    public class OperacionProducto
    {
        //DEVUELVE CATEGORIA DEL PRODUCTO
        public DataSet Datosporid(int CatProd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();


                    var select = "SELECT * FROM Producto WHERE IdCategoria  =" + CatProd;

                    //Procesa un comando en in dataset
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);

                    var ds = new DataSet();
                    //llena el dataset
                    dataAdapter.Fill(ds);
                    //retornamos el dataset
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        //string
        public DataSet Datosporid(string Nombreprod)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();


                    var select = "SELECT * FROM Producto WHERE NombreProducto ='" + Nombreprod + "'";
                    //Procesa un comando en in dataset
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    //llena el dataset
                    dataAdapter.Fill(ds);
                    //retornamos el dataset
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }




        }
        public DataSet Datosporcodigo(string cod)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();


                    var select = "SELECT * FROM Producto WHERE CodigoProducto ='" + cod + "'";
                    //Procesa un comando en in dataset
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    //llena el dataset
                    dataAdapter.Fill(ds);
                    //retornamos el dataset
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }



        }

        public DataSet DatosporFecha(DateTime fecha)
        { 
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();


                    var select = "SELECT * FROM BitacoraTraslado WHERE FechaTraslado =" + fecha ;
                    //Procesa un comando en in dataset
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    //llena el dataset
                    dataAdapter.Fill(ds);
                    //retornamos el dataset
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
        public DataSet DatosporFecha(string fecha)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();


                    var select = "SELECT * FROM BitacoraTraslado WHERE FechaTraslado ='" + fecha + "'";
                    //Procesa un comando en in dataset
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    //llena el dataset
                    dataAdapter.Fill(ds);
                    //retornamos el dataset
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        public DataSet BuscarDetalleIngreso(int IdProd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();
                    var select = "SELECT * FROM DetallesIngreso WHERE IdProducto =" + IdProd;
                    //Procesa un comando en in dataset
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);

                    var ds = new DataSet();
                    //llena el dataset
                    dataAdapter.Fill(ds);
                    //retornamos el dataset
                    return ds;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void llenardataingreso(DataGridView grid)
        {
            SqlConnection sqlcon = new SqlConnection();

            sqlcon.ConnectionString = Conectar.cnn;
            sqlcon.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM IngresoProductos ORDER BY IdIngreso DESC;", sqlcon);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            grid.DataSource = dt;
        }

        public DataSet BuscarDetalleTraslado(int IdProd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();
                    var select = "SELECT * FROM Detalle_Traslado WHERE IdTraslado =" + IdProd;
                    //Procesa un comando en in dataset
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);

                    var ds = new DataSet();
                    //llena el dataset
                    dataAdapter.Fill(ds);
                    //retornamos el dataset
                    return ds;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet bodeg(int CatProd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();


                    var select = "SELECT * FROM Producto WHERE IdBodega  =" + CatProd;

                    //Procesa un comando en in dataset
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);

                    var ds = new DataSet();
                    //llena el dataset
                    dataAdapter.Fill(ds);
                    //retornamos el dataset
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
        public void llenardata(DataGridView grid)
        {
            SqlConnection sqlcon = new SqlConnection();

            sqlcon.ConnectionString = Conectar.cnn;
            sqlcon.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM Producto;", sqlcon);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            grid.DataSource = dt;
        }
        public void llenardatatraslado(DataGridView grid)
        {
            SqlConnection sqlcon = new SqlConnection();

            sqlcon.ConnectionString = Conectar.cnn;
            sqlcon.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM Traslado ORDER BY IdTraslado;", sqlcon);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);

            grid.DataSource = dt;
        }


      



        public void gridReporte(int idBod, DataGridView dgv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();

                    //var select = "SELECT * FROM DetallesIngreso";

                    var select = "SELECT d.idBodega, b.NombreBodega, p.NombreProducto, p.CodigoProducto, c.NombreCategoria, d.Stock_Inicial, d.Stock_Actual, i.Fecha_Ingreso, m.NombreMarca"
                                 + " FROM detallesIngreso d, bodega b, producto p, categoriaProducto c, ingresoProductos i, marca m"
                                 + " WHERE d.IdBodega = " + idBod + " AND b.IdBodega = d.IdBodega AND p.IdProducto = d.IdProducto AND c.IdCategoria = p.IdCategoria AND i.IdIngreso = d.IdIngreso AND m.IdMarca = p.IdMarca";

                    //Procesa un comando en dataTable
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);

                    var ds = new DataTable();
                    //llena el datatable
                    dataAdapter.Fill(ds);
                    //retornamos el datatable
                    dgv.DataSource = ds;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        public void gridReporteBit(DataGridView dgv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();

                    //var select = "SELECT * FROM DetallesIngreso";

                    var select = "SELECT BT.idBitacora, C.NombreCategoria, P.Nombre, P.Apellido, B.NombreBodega, BT.FechaIngreso, BT.Cantidad,B1.NombreBodega, Bt.FechaTraslado"
                                + " FROM BitacoraTraslado BT, CategoriaProducto C, Personal P, Bodega B, Bodega B1"
                                + " WHERE BT.IdBitacora > 0 AND C.IdCategoria = BT.IdCategoria AND P.IdPersonal = BT.IdPersonal AND B.IdBodega = BT.IdBodega AND B1.IdBodega = BT.IdBodegaFinal ORDER BY BT.FechaIngreso DESC; ";

                    //Procesa un comando en dataTable
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);

                    var ds = new DataTable();
                    //llena el datatable
                    dataAdapter.Fill(ds);
                    //retornamos el datatable
                    dgv.DataSource = ds;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        



        public void buscarBitacora(string fecha, DataGridView dgv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();

                    //var select = "SELECT * FROM DetallesIngreso";

                    var select = "select * from BitacoraTraslado where FechaTraslado= cast('"+fecha+"' AS datetime)";

                    //Procesa un comando en dataTable
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);

                    var ds = new DataTable();
                    //llena el datatable
                    dataAdapter.Fill(ds);
                    //retornamos el datatable
                    dgv.DataSource = ds;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }



        public void borraBitacora(int id, DataGridView dgv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Conectar.cnn;
                    conn.Open();

                    //var select = "SELECT * FROM DetallesIngreso";

                    var select = "delete from BitacoraTraslado where IdBitacora = " +id;

                    //Procesa un comando en dataTable
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    //constructor del comando para ejecutarlo 
                    var comandBuilder = new SqlCommandBuilder(dataAdapter);

                    var ds = new DataTable();
                    //llena el datatable
                    dataAdapter.Fill(ds);
                    //retornamos el datatable
                    dgv.DataSource = ds;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

    
    }
}
