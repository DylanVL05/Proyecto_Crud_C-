using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Cliente : Form
    {
        private ConexionBD conexionBD = new ConexionBD();
        private bool filaSeleccionada = false;

        public Cliente()
        {
            InitializeComponent();

            // Configura el DataGridView y otros componentes según sea necesario
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // Llamada al método para cargar los datos en el DataGridView
            CargarDatosClientes();
        }

        private void CargarDatosClientes()
        {
            // No es necesario crear una nueva instancia de ConexionBD aquí
            // Utiliza la instancia existente en la clase
            DataTable datosClientes = conexionBD.ObtenerDatosClientes();

            // Asigna datos al DataGridView
            dataGridView1.DataSource = datosClientes;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0] != null)
                {
                    // Obtener los valores de la fila seleccionada
                    int clienteID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ClienteID"].Value);
                    string nombreActual = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Nombre"].Value);
                    string correoActual = Convert.ToString(dataGridView1.SelectedRows[0].Cells["CorreoElectronico"].Value);

                    // Mostrar los datos en los TextBox
                    nombre_textbox.Text = nombreActual;
                    correo_textbox.Text = correoActual;

                    // Actualizar la variable de filaSeleccionada a true
                    filaSeleccionada = true;
                }
                else
                {
                    // Si no se ha seleccionado una fila o la fila es nula, actualiza la variable a false
                    filaSeleccionada = false;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción, puedes mostrar un mensaje de error o realizar otras acciones según sea necesario
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string nombre = nombre_textbox.Text;
            string correoElectronico = correo_textbox.Text;

            // Validar que se haya ingresado un nombre (puedes agregar más validaciones según tus necesidades)
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar el nuevo cliente a la base de datos
            conexionBD.AgregarCliente(new Cliente_cl
            {
                Nombre = nombre,
                CorreoElectronico = correoElectronico
            });

            // Opcional: Actualizar la visualización de los datos en el DataGridView u otro control
            CargarDatosClientes();

            // Opcional: Mostrar un mensaje de éxito
            MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }




        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_editar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una fila
            if (string.IsNullOrWhiteSpace(nombre_textbox.Text))
            {
                MessageBox.Show("Por favor, seleccione un cliente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los nuevos valores de los TextBox
            string nuevoNombre = nombre_textbox.Text;
            string nuevoCorreoElectronico = correo_textbox.Text;

            // Obtener el ClienteID de la fila seleccionada (suponiendo que la columna "ClienteID" está en la posición 0)
            int clienteID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ClienteID"].Value);

            // Actualizar el cliente en la base de datos
            conexionBD.ActualizarCliente(new Cliente_cl
            {
                ClienteID = clienteID,
                Nombre = nuevoNombre,
                CorreoElectronico = nuevoCorreoElectronico
            });

            // Opcional: Actualizar la visualización de los datos en el DataGridView u otro control
            CargarDatosClientes();

            // Opcional: Mostrar un mensaje de éxito
            MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los TextBox después de la actualización
            nombre_textbox.Text = string.Empty;
            correo_textbox.Text = string.Empty;
        }


    

            // Luego, al guardar la edición, puedes usar el índice de fila seleccionada
            private void GuardarEdicion()
        {
            // Validar que se haya seleccionado una fila
            if (!filaSeleccionada)
            {
                MessageBox.Show("Por favor, seleccione un cliente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ClienteID de la fila seleccionada (suponiendo que la columna "ClienteID" está en la posición 0)
            int clienteID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ClienteID"].Value);
            string nuevoNombre = nombre_textbox.Text;
            string nuevoCorreoElectronico = correo_textbox.Text;

            // Actualizar el cliente en la base de datos
            conexionBD.ActualizarCliente(new Cliente_cl
            {
                ClienteID = clienteID,
                Nombre = nuevoNombre,
                CorreoElectronico = nuevoCorreoElectronico
            });

            // Opcional: Actualizar la visualización de los datos en el DataGridView u otro control
            CargarDatosClientes();

            // Opcional: Mostrar un mensaje de éxito
            MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void materialButton2_Eliminar_Click(object sender, EventArgs e)
        {
            // Obtener la fila seleccionada del DataGridView
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0] : null;

            // Validar que se haya seleccionado una fila
            if (filaSeleccionada == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ClienteID de la fila seleccionada (suponiendo que la columna "ClienteID" está en la posición 0)
            int clienteID = Convert.ToInt32(filaSeleccionada.Cells["ClienteID"].Value);

            // Preguntar al usuario si realmente desea eliminar el cliente
            DialogResult resultado = MessageBox.Show($"¿Está seguro de que desea eliminar al cliente con ID {clienteID}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Crear una instancia de ConexionBD
                ConexionBD conexionBD = new ConexionBD();

                // Eliminar el cliente de la base de datos
                conexionBD.EliminarCliente(clienteID);

                // Opcional: Actualizar la visualización de los datos en el DataGridView u otro control
                CargarDatosClientes();

                // Opcional: Mostrar un mensaje de éxito
                MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
