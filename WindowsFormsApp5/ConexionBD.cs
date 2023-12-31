using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using System.Text;
    using WindowsFormsApp5;





    public class ConexionBD
    {
        private readonly string nombreServidor = "DESKTOP-DE2J0FH";
        private readonly string nombreBaseDatos = "practica";

        public DataTable ObtenerDatosClientes()
        {
            DataTable dtClientes = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM dbo.Clientes";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            adaptador.Fill(dtClientes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dtClientes;
        }

        public void AgregarCliente(Cliente_cl cliente)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
                {
                    conexion.Open();

                    // No incluyas el campo ClienteID en la lista de columnas
                    string consulta = "INSERT INTO dbo.Clientes (Nombre, CorreoElectronico) VALUES (@Nombre, @CorreoElectronico)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        comando.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ActualizarCliente(Cliente_cl cliente)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
                {
                    conexion.Open();

                    string consulta = "UPDATE dbo.Clientes SET Nombre = @Nombre, CorreoElectronico = @CorreoElectronico WHERE ClienteID = @ClienteID";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        comando.Parameters.AddWithValue("@CorreoElectronico", cliente.CorreoElectronico);
                        comando.Parameters.AddWithValue("@ClienteID", cliente.ClienteID);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EliminarCliente(int clienteID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
                {
                    conexion.Open();

                    string consulta = "DELETE FROM dbo.Clientes WHERE ClienteID = @ClienteID";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ClienteID", clienteID);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerCadenaConexion()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Data Source=").Append(nombreServidor).Append(";");
            builder.Append("Initial Catalog=").Append(nombreBaseDatos).Append(";");
            builder.Append("Integrated Security=True;");
            return builder.ToString();
        }
    }
}