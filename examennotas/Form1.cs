using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examennotas
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (string dato2, string dato3, string dato4)> estudiantes = new Dictionary<string, (string, string, string)>();

        private string dniTemporal;
        private string dato2;
        private string dato3;
        private string dato4;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string dniTemporal = dni.Text; // Ahora no hay confusión
            string dato2 = textBox2.Text;
            string dato3 = textBox3.Text;
            string dato4 = textBox4.Text;

            if (!string.IsNullOrEmpty(dniTemporal) && !estudiantes.ContainsKey(dniTemporal))
            {
                estudiantes[dniTemporal] = (dato2, dato3, dato4);
                MessageBox.Show("Datos guardados correctamente.");
            }
            else
            {
                estudiantes[dniTemporal] = (dato2, dato3, dato4);
                MessageBox.Show("Datos guardados correctamente.");
            }
        }

        private void dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmos_Click(object sender, EventArgs e)
        {
            listalum.Items.Clear(); // Limpiar la lista antes de mostrar los datos

            if (estudiantes.Count == 0)
            {
                MessageBox.Show("No hay estudiantes registrados.");
                return;
            }

            foreach (var estudiante in estudiantes)
            {
                string dni = estudiante.Key;
                string dato2 = estudiante.Value.dato2; // Suponiendo que dato2 es el nombre
                string dato3 = estudiante.Value.dato3; // Otro dato relevante
                string dato4 = estudiante.Value.dato4;  // Nota del estudiante

                listalum.Items.Add($"DNI: {dni}, Apellido: {dato2}, Nombre: {dato3}, Calificacion: {dato4}");
            }
        }

        private void btnota_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo personalizado para ingresar el DNI
            Form inputForm = new Form();
            inputForm.Width = 300;
            inputForm.Height = 150;
            inputForm.Text = "Buscar Nota";

            Label label = new Label() { Left = 10, Top = 10, Text = "Ingrese el DNI:" };
            TextBox textBox = new TextBox() { Left = 10, Top = 30, Width = 260 };
            Button confirmButton = new Button() { Text = "Aceptar", Left = 100, Width = 100, Top = 60 };

            confirmButton.DialogResult = DialogResult.OK;

            inputForm.Controls.Add(label);
            inputForm.Controls.Add(textBox);
            inputForm.Controls.Add(confirmButton);

            inputForm.AcceptButton = confirmButton;

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string dniBuscado = textBox.Text;

                if (estudiantes.TryGetValue(dniBuscado, out var estudiante))
                {
                    MessageBox.Show($"La nota de {estudiante.dato2} es: {estudiante.dato4}");
                }
                else
                {
                    MessageBox.Show("DNI no encontrado.");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void elimi_Click(object sender, EventArgs e)
        {
            // Crear un pequeño formulario para pedir el DNI
            Form inputForm = new Form();
            inputForm.Width = 300;
            inputForm.Height = 150;
            inputForm.Text = "Eliminar Estudiante";

            Label label = new Label() { Left = 10, Top = 10, Text = "Ingrese el DNI a eliminar:" };
            TextBox textBox = new TextBox() { Left = 10, Top = 30, Width = 260 };
            Button confirmButton = new Button() { Text = "Eliminar", Left = 100, Width = 100, Top = 60 };

            confirmButton.DialogResult = DialogResult.OK;

            inputForm.Controls.Add(label);
            inputForm.Controls.Add(textBox);
            inputForm.Controls.Add(confirmButton);

            inputForm.AcceptButton = confirmButton;

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string dniEliminar = textBox.Text;

                if (estudiantes.ContainsKey(dniEliminar))
                {
                    var confirmacion = MessageBox.Show($"¿Estás seguro de eliminar al estudiante con DNI {dniEliminar}?",
                                                       "Confirmar eliminación",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        estudiantes.Remove(dniEliminar);
                        MessageBox.Show($"El estudiante con DNI {dniEliminar} ha sido eliminado correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no existe en el registro.");
                }
            }
        }

        private void modifi_Click(object sender, EventArgs e)
        {
            // Preguntar el DNI
            string dniModificar = Prompt.ShowDialog("Ingrese el DNI del estudiante que desea modificar:", "Modificar Nota");

            if (estudiantes.ContainsKey(dniModificar))
            {
                // Mostrar la nota actual
                var datosActuales = estudiantes[dniModificar];
                MessageBox.Show($"Nota actual del estudiante con DNI {dniModificar}: {datosActuales.dato4}");

                // Preguntar la nueva nota
                string nuevaNota = Prompt.ShowDialog($"Ingrese la nueva nota para el estudiante con DNI {dniModificar}:", "Nueva Nota");

                if (!string.IsNullOrEmpty(nuevaNota))
                {
                    // Actualizar solo la nota en el diccionario
                    estudiantes[dniModificar] = (datosActuales.dato2, datosActuales.dato3, nuevaNota);

                    MessageBox.Show($"La nota del estudiante con DNI {dniModificar} ha sido modificada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se ingresó una nota válida.");
                }
            }
            else
            {
                MessageBox.Show("El DNI ingresado no existe en el registro.");
            }
        }

        // Clase para mostrar un cuadro de diálogo simple
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 200,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
                TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 350 };
                Button confirmation = new Button() { Text = "Aceptar", Left = 150, Width = 100, Top = 100, DialogResult = DialogResult.OK };

                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listalum.Items.Clear(); // Limpiar la lista antes de mostrar nuevos datos

            const double notaPerfecta = 10.0; // Nota máxima
            bool hayPerfectos = false;

            foreach (var estudiante in estudiantes)
            {
                string dni = estudiante.Key;
                string nombre = estudiante.Value.dato2; // Suponiendo que es el nombre del estudiante
                string notaStr = estudiante.Value.dato4;

                if (double.TryParse(notaStr, out double nota) && nota == notaPerfecta)
                {
                    listalum.Items.Add($"DNI: {dni}, Nombre: {nombre}, Nota: {nota}");
                    hayPerfectos = true;
                }
            }

            if (!hayPerfectos)
            {
                MessageBox.Show("No hay estudiantes con nota perfecta (10).");
            }
        }

        private void btnbaja_Click(object sender, EventArgs e)
        {
            listalum.Items.Clear(); // Limpiar la lista antes de mostrar nuevos datos

            // Definir el umbral de baja nota (puedes cambiarlo)
            const double umbralBajaNota = 7.0;

            bool hayBajas = false;

            foreach (var estudiante in estudiantes)
            {
                string dni = estudiante.Key;
                string dato2 = estudiante.Value.dato2;
                string notaStr = estudiante.Value.dato4;

                if (double.TryParse(notaStr, out double nota) && nota < umbralBajaNota)
                {
                    listalum.Items.Add($"DNI: {dni}, Nombre: {dato2}, Nota: {nota}");
                    hayBajas = true;
                }
            }

            if (!hayBajas)
            {
                MessageBox.Show("No hay estudiantes con notas bajas.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listalum.Items.Clear(); // Limpiar la lista antes de mostrar nuevos datos

            const double umbralAltaNota = 7.0; // Puedes cambiar este umbral si lo necesitas
            bool hayAprobados = false;

            foreach (var estudiante in estudiantes)
            {
                string dni = estudiante.Key;
                string dato2 = estudiante.Value.dato2; // Por ejemplo, el nombre
                string notaStr = estudiante.Value.dato4;

                if (double.TryParse(notaStr, out double nota) && nota >= umbralAltaNota)
                {
                    listalum.Items.Add($"DNI: {dni}, Nombre: {dato2}, Nota: {nota}");
                    hayAprobados = true;
                }
            }

            if (!hayAprobados)
            {
                MessageBox.Show("No hay estudiantes con notas altas.");
            }
        }
    }
}

