using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practico4
{
    public partial class Formulario4 : Form
    {
        public Formulario4()
        {
            InitializeComponent();
        }

        private void Formulario4_Load(object sender, EventArgs e)
        {
            DatosPanel.BackColor = Color.FromArgb(120, 255, 255, 255);

            // limpiamos las columnas previas
            DataClientes.Columns.Clear();

            // agregamos las columnas de texto
            DataClientes.Columns.Add("colApellido", "Apellido");
            DataClientes.Columns.Add("colNombre", "Nombre");
            DataClientes.Columns.Add("colFecha", "Fecha Nacimiento");
            DataClientes.Columns.Add("colSexo", "Sexo");

            // columna de tipo boton para eliminar
            DataGridViewButtonColumn btnColEliminar = new DataGridViewButtonColumn();
            btnColEliminar.Name = "colEliminar";
            btnColEliminar.HeaderText = "Eliminar";
            btnColEliminar.Text = "Eliminar";
            btnColEliminar.UseColumnTextForButtonValue = true; // para que el texto "Eliminar" aparezca en cada boton
            DataClientes.Columns.Add(btnColEliminar);

            // columna de Saldo
            DataClientes.Columns.Add("colSaldo", "Saldo");

            // columna de Imagen para la Foto
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "colFoto";
            imgCol.HeaderText = "Foto";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch; // ajusta la foto a la celda
            DataClientes.Columns.Add(imgCol);

            // columna de texto para la ruta completa
            DataClientes.Columns.Add("colRuta", "Ruta");

            // formato de fuentes distintas para Apellido y Nombre 
            DataClientes.Columns["colApellido"].DefaultCellStyle.Font = new Font("Courier New", 10, FontStyle.Bold);
            DataClientes.Columns["colNombre"].DefaultCellStyle.Font = new Font("Segoe Script", 10, FontStyle.Italic);

            // alturas de las filas para que la foto de vea bien
            DataClientes.RowTemplate.Height = 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // instanciamos el cuadro de dialogo para abrir archivos
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // filtramos solo para formatos de imagen
                openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccione una foto de perfil";

                // si el usuario selecciona un archivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaOrigen = openFileDialog.FileName;
                    string nombreArchivo = Path.GetFileName(rutaOrigen);

                    // definimos la carpeta de destino en bin\Debug\Fotos
                    string carpetaDestino = Path.Combine(Application.StartupPath, "Fotos");

                    // si no existe la carpeta fotos la creamos
                    if (!Directory.Exists(carpetaDestino))
                    {
                        Directory.CreateDirectory(carpetaDestino);
                    }

                    string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                    // cpoiamos el archivo al proyecto
                    File.Copy(rutaOrigen, rutaDestino, true);

                    // mostramos la imagen y la ruta
                    PAvatar.Image = Image.FromFile(rutaDestino);
                    TFoto.Text = rutaDestino;
                }
            }
        }

        private string FormatearTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return string.Empty;

            texto = texto.Trim();
            if (texto.Length == 1)
                return texto.ToUpper();

            // primera letra en mayuscula y resto en minusculas
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }

        private void TNombre_Leave(object sender, EventArgs e)
        {
            TNombre.Text = FormatearTexto(TNombre.Text);
        }

        private void TApellido_Leave(object sender, EventArgs e)
        {
            TApellido.Text = FormatearTexto(TApellido.Text);
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // validaciones de campos vacíos
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TSaldo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validar que el saldo sea un numero valido
            if (!decimal.TryParse(TSaldo.Text.Trim(), out decimal saldo))
            {
                MessageBox.Show("El saldo ingresado no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TSaldo.Focus();
                return;
            }

            // obtener el texto del sexo según el radiobutton
            string sexo = RHombre.Checked ? "Hombre" : "Mujer";

            // obtenemos la imagen y la ruta
            Image imagenParaGrid = PAvatar.Image;
            string rutaImagen = TFoto.Text;

            // agregar la fila al DataGridView y capturar el indice de la nueva fila
            int indiceFila = DataClientes.Rows.Add(
                TApellido.Text.Trim(),
                TNombre.Text.Trim(),
                DateFechaNac.Value.ToShortDateString(),
                sexo,
                "Eliminar",
                saldo.ToString("0.##"),
                imagenParaGrid,
                rutaImagen
            );

            // condición de Saldo Menor a $50 -> pintar la fila de Rojo 
            if (saldo < 50)
            {
                DataClientes.Rows[indiceFila].DefaultCellStyle.BackColor = Color.Red;
                DataClientes.Rows[indiceFila].DefaultCellStyle.ForeColor = Color.White;
            }

            // limpiar los controles para el siguiente ingreso
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TSaldo.Clear();
            TFoto.Clear();
            RHombre.Checked = true;
            DateFechaNac.Value = DateTime.Now;
        }

        private void DataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // validamos que no se haya clickeado el encabezado (indice de fila >= 0)
            if (e.RowIndex >= 0)
            {
                // verificamos si el clic fue en la columna del botón "colEliminar"
                if (DataClientes.Columns[e.ColumnIndex].Name == "colEliminar")
                {
                    // obtenemos el nombre y apellido del registro para el mensaje
                    string apellido = DataClientes.Rows[e.RowIndex].Cells["colApellido"].Value?.ToString() ?? "";
                    string nombre = DataClientes.Rows[e.RowIndex].Cells["colNombre"].Value?.ToString() ?? "";

                    // mensaje de confirmación antes de eliminar
                    DialogResult confirmacion = MessageBox.Show(
                        $"¿Está seguro que desea eliminar el registro de {nombre} {apellido}?",
                        "Confirmar Eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2 // Foco en "No" por seguridad
                    );

                    // si el usuario presiona "Sí", removemos la fila de la tabla
                    if (confirmacion == DialogResult.Yes)
                    {
                        DataClientes.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void DataClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verificamos que la fila sea válida y no el encabezado
            if (e.RowIndex >= 0)
            {
                // leemos el valor de la columna Sexo
                string sexoSeleccionado = DataClientes.Rows[e.RowIndex].Cells["colSexo"].Value?.ToString() ?? "";

                // marcamos el RadioButton correspondiente
                if (sexoSeleccionado == "Hombre")
                {
                    RHombre.Checked = true;
                }
                else if (sexoSeleccionado == "Mujer")
                {
                    RMujer.Checked = true;
                }

                // cargamos también la foto en el PictureBox al hacer clic en la fila
                if (DataClientes.Rows[e.RowIndex].Cells["colFoto"].Value is Image img)
                {
                    PAvatar.Image = img;
                }
            }
        }
    }
}
