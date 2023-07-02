using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_Recursividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] datos = new string[10];
        // Funcion para agregar datos de tipo string al array
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int indice = listB_datos.Items.Count;
            if (txt_dato.Text != "")
            {
                datos[indice] = txt_dato.Text;
                listB_datos.Items.Add(datos[indice]);
                if (indice == 9)
                    btn_Agregar.Enabled = false;
                txt_dato.Text = "";
            } else
            {
                MessageBox.Show("¡Error! Debe completar el cuadro de texto antes de realizar esta accion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Funcion para permitir solo letras en el textbox
        private void txt_dato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        // Boton para ordenar
        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            if (listB_datos.Items.Count == 10)
            {
                OrdenarAscendente(datos, datos.Length);
                listB_datos.Items.Clear();
                listB_datos.Items.AddRange(datos);
            } else
            {
                MessageBox.Show("¡Error! Debe llenar el array con 10 datos antes de poder realizar esta accion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Funcion que permite ordenar de forma ascendente utilizando el metodo de recursividad
        void OrdenarAscendente(string[] array, int n)
        {
            // Caso base: si el tamaño del array es 1 o menos, ya está ordenado
            if (n <= 1)
                return;

            // Ordenar el array excepto el último elemento
            OrdenarAscendente(array, n - 1);

            // Colocar el último elemento en la posición correcta
            string ultimoElemento = array[n - 1];
            int j = n - 2;

            while (j >= 0 && string.Compare(array[j], ultimoElemento) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = ultimoElemento;
        }
    }
}
