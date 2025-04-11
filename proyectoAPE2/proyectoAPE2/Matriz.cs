using ayuda1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proyectoAPE2
{
    public partial class Matriz : Form
    {
        public Matriz()
        {
            InitializeComponent();
            // Asignar validaciones
            txtFilas.KeyPress += ValidarEntradaNumerica;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Evento para validar que solo se ingresen números en el DataGridView
            dgwMatriz.EditingControlShowing += dgwMatriz_EditingControlShowing;


        }

        private void dgwMatriz_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Remover eventos anteriores
            e.Control.KeyPress -= new KeyPressEventHandler(SoloNumeros_KeyPress);

            // Verificar que sea una celda editable de tipo TextBox
            if (dgwMatriz.CurrentCell.ColumnIndex >= 0)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(SoloNumeros_KeyPress);
                }
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidarEntradaNumerica(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permitir números, tecla de control (como backspace), y una coma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            // Solo una coma permitida
            if (e.KeyChar == ',' && txt.Text.Contains(","))
            {
                e.Handled = true;
                return;
            }

            // Validar el número cuando se presiona Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (decimal.TryParse(txt.Text, out decimal valor))
                {
                    if (valor < 1 || valor > 30)
                    {
                        MessageBox.Show("El valor debe estar entre 1 y 30.", "Valor fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFilas.Text, out int filas) && int.TryParse(txtFilas.Text, out int columnas))
            {
                if (filas <= 30 && columnas <= 30 && filas > 0 && columnas > 0)
                {
                    dgwMatriz.Columns.Clear();
                    dgwMatriz.Rows.Clear();
                    for (int i = 0; i < columnas; i++)
                    {
                        dgwMatriz.Columns.Add("Col" + i, "Col " + (i + 1));
                    }
                    dgwMatriz.Rows.Add(filas);
                }
                else
                {
                    MessageBox.Show("Los valores deben estar entre 1 y 10.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese números válidos en filas y columnas.");
            }
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            txtFilas.Clear();
            dgwMatriz.Columns.Clear();
            dgwMatriz.Rows.Clear();
            dgwMatrizInversa.Columns.Clear();  // Limpiar columnas de la matriz inversa
            dgwMatrizInversa.Rows.Clear();     // Limpiar filas de la matriz inversa

            // Limpiar el texto del Label
            lblResultadoDiagonal.Text = "";  // Limpiar el texto del Label
        }

        //este boton permite borrar los datos de datagridview

        private void btnDatos_Click(object sender, EventArgs e)
        {
            // Limpiar dgwMatriz
            foreach (DataGridViewRow row in dgwMatriz.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }

            // Limpiar dgwMatrizInversa
            foreach (DataGridViewRow row in dgwMatrizInversa.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }

            // Limpiar el texto del Label
            lblResultadoDiagonal.Text = "";  // Limpiar el texto del Label
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            // Limpiar matriz principal
            dgwMatriz.Columns.Clear();
            dgwMatriz.Rows.Clear();

            // Limpiar matriz inversa
            dgwMatrizInversa.Columns.Clear();
            dgwMatrizInversa.Rows.Clear();

            // Limpiar el texto del Label
            lblResultadoDiagonal.Text = "";  // Limpiar el texto del Label
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCaratula caratula = new FormCaratula();
            caratula.Show();
        }

        private double[,] InvertirMatriz(double[,] matriz)
        {
            int n = matriz.GetLength(0);
            double[,] resultado = new double[n, n];
            double[,] temp = (double[,])matriz.Clone();

            // Crear matriz identidad
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultado[i, j] = (i == j) ? 1.0 : 0.0;
                }
            }

            // Método de Gauss-Jordan
            for (int i = 0; i < n; i++)
            {
                double pivote = temp[i, i];
                if (pivote == 0)
                    throw new Exception("La matriz no tiene inversa.");

                for (int j = 0; j < n; j++)
                {
                    temp[i, j] /= pivote;
                    resultado[i, j] /= pivote;
                }

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = temp[k, i];
                        for (int j = 0; j < n; j++)
                        {
                            temp[k, j] -= factor * temp[i, j];
                            resultado[k, j] -= factor * resultado[i, j];
                        }
                    }
                }
            }

            return resultado;
        }

        private double[,] ObtenerMatriz()
        {
            int filas = dgwMatriz.RowCount;
            int columnas = dgwMatriz.ColumnCount;

            double[,] matriz = new double[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    object valor = dgwMatriz.Rows[i].Cells[j].Value;

                    if (valor != null && double.TryParse(valor.ToString(), out double numero))
                    {
                        matriz[i, j] = numero;
                    }
                    else
                    {
                        throw new Exception($"Valor inválido en la celda [{i + 1}, {j + 1}]");
                    }
                }
            }

            return matriz;
        }


        private void btnMatrizInversa_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] matrizOriginal = ObtenerMatriz();
                int filas = matrizOriginal.GetLength(0);
                int columnas = matrizOriginal.GetLength(1);

                if (filas != columnas)
                {
                    MessageBox.Show("La matriz debe ser cuadrada para poder invertirla.");
                    return;
                }

                double[,] inversa = InvertirMatriz(matrizOriginal);

                // Mostrar resultado en dgwMatrizInversa
                dgwMatrizInversa.Columns.Clear();
                dgwMatrizInversa.Rows.Clear();

                for (int i = 0; i < columnas; i++)
                {
                    dgwMatrizInversa.Columns.Add("Col" + i, "Col " + (i + 1));
                }

                for (int i = 0; i < filas; i++)
                {
                    object[] fila = new object[columnas];
                    for (int j = 0; j < columnas; j++)
                    {
                        fila[j] = Math.Round(inversa[i, j], 4); // Redondeo opcional
                    }
                    dgwMatrizInversa.Rows.Add(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al invertir la matriz: " + ex.Message);
            }
        }

        private void txtFilas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAyuda2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayuda2 help = new Ayuda2();
            help.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Final final = new Final();
            final.Show();
        }



        private string CalcularSumasDiagonal(double[,] matriz, string nombre)
        {
            int n = matriz.GetLength(0);
            double sumaPrincipal = 0;
            double sumaSecundaria = 0;

            for (int i = 0; i < n; i++)
            {
                sumaPrincipal += matriz[i, i];
                sumaSecundaria += matriz[i, n - 1 - i];

                // Depuración (esto lo podés quitar después)
                Console.WriteLine($"{nombre} - principal[{i},{i}] = {matriz[i, i]}");
                Console.WriteLine($"{nombre} - secundaria[{i},{n - 1 - i}] = {matriz[i, n - 1 - i]}");
            }

            return $"Suma diagonal principal de la {nombre} es: {sumaPrincipal}\n" +
                   $"Suma diagonal secundaria de la {nombre} es: {sumaSecundaria}";
        }


        private void MostrarSumaDiagonales()
        {
            // Limpiar el texto del Label antes de mostrar un nuevo resultado (opcional)
            lblResultadoDiagonal.Text = "";

            try
            {
                double[,] matrizNormal = ObtenerMatriz();
                lblResultadoDiagonal.Text += CalcularSumasDiagonal(matrizNormal, "matriz normal") + "\n";
            }
            catch
            {
                lblResultadoDiagonal.Text += "No se pudo calcular la suma de diagonales de la matriz normal." + "\n";
            }

            try
            {
                int filas = dgwMatrizInversa.RowCount;
                int columnas = dgwMatrizInversa.ColumnCount;

                if (filas == columnas && filas > 0)
                {
                    double[,] matrizInversa = new double[filas, columnas];

                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            object valor = dgwMatrizInversa.Rows[i].Cells[j].Value;
                            if (valor != null && double.TryParse(valor.ToString(), System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture, out double numero))
                            {
                                matrizInversa[i, j] = numero;
                            }
                            else
                            {
                                throw new Exception("Valor inválido en la matriz inversa.");
                            }
                        }
                    }

                    lblResultadoDiagonal.Text += "\n";  // Espacio entre los resultados de la matriz normal y la inversa
                    lblResultadoDiagonal.Text += CalcularSumasDiagonal(matrizInversa, "matriz inversa") + "\n";
                }
                else
                {
                    lblResultadoDiagonal.Text += "\n";  // Espacio
                    lblResultadoDiagonal.Text += "La matriz inversa no está definida o no es cuadrada." + "\n";
                }
            }
            catch
            {
                lblResultadoDiagonal.Text += "No se pudo calcular la suma de diagonales de la matriz inversa." + "\n";
            }
        }


        private void btnSumaDiagonales_Click(object sender, EventArgs e)
        {
            // Limpiar el texto del Label antes de mostrar un nuevo resultado (opcional)
            lblResultadoDiagonal.Text = "";

            // Mostrar las sumas de diagonales
            MostrarSumaDiagonales();
        }
    }
}
