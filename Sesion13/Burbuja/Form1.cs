using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Burbuja.operaciones;

namespace Burbuja
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[3];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int number =  int.Parse(tbNumero.Text);
            numbers[i++] = number;
            showNumbers();
        }

        private void showNumbers()
        {
            if(numbers.Length > 0)
            {
                lbNumbers.Items.Clear();
            }


            for(int i = 0; i < numbers.Length; i++)
            {
                lbNumbers.Items.Add(numbers[i]);    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Burbujita burbujita = new Burbujita();
            burbujita.OrdenarBurbuja(numbers);
            showNumbers();


        }
    }
}
