using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
        public partial class Form1 : Form
        {   //variabili
            public int dim;
            public string[] arr;
        public string[] arr2;
        public Form1()
            {
                InitializeComponent();
                arr = new string[100];
                arr2 = new string[100];
                dim = 0;

                 for(int i = 0; i < arr.Length; i++)
            {
                arr2[i] = "";
            }
            }

          

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Scrittaprodotto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aggiunta(arr,arr2, ref dim, Scrittaprodotto.Text,textBox1.Text);
            Scrittaprodotto.Text = "";
            Scrittaprodotto.Focus();
            textBox1.Text = "";
            textBox1.Focus();
            MessageBox.Show("aggiunto");

        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            Rimosso(arr,arr2, ref dim);
            textBox3.Text = "";
            textBox3.Focus();
            textBox5.Text = "";
            textBox5.Focus();
            MessageBox.Show("Rimosso.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifica(arr, ref dim, Modificare.Text, textBox4.Text,Modificato.Text, textBox2.Text);
            Modificare.Text = "";
            Modificare.Focus();
            textBox4.Text = "";
            textBox4.Focus();
            Modificato.Text = "";
            Modificato.Focus();
            textBox2.Text = "";
            textBox2.Focus();
            MessageBox.Show("Modificato.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Prezztot(arr2); 
                MessageBox.Show("Sconto applicato");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            perc(arr2, listview2);

            aggiornaVista(dim);

            listView2.Text = "";
            listView2.Focus();
            textBox6.Text = "";
            textBox6.Focus();

        }

        //funzioni di servizio
        public void aggiunta(string[] arr, string[] arr2, ref int dim, string nome,string r)
        {
            arr[dim] = nome ;
            arr2[dim] = r;
            dim++;
        }

        public void Rimosso(string[] arr, string[] arr2, ref int dim)
        {
            for (int i = 0; i < dim; i++)
            {

                if (arr[i] == textBox3.Text)
                {
                    for (int j = i; j < dim; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                }

                if (arr2[i] == textBox5.Text)
                {
                    for (int j = i; j < dim; j++)
                    {
                        arr2[j] = arr2[j + 1];
                    }
                }
            }

        }

        public void Modifica(string[] arr, ref int dim,string a,string b,string r,string g)
        {
            for (int i = 0; i < dim; i++)
            {

                if (arr[i] == a)
                {
                    arr[i] = r;
                }

                if (arr2[i] == b)
                {
                    arr2[i] = g;
                } 
            }
        }

        public void aggiornaVista(int dim)
        {
            listView1.Items.Clear();

            for (int i = 0; i < dim; i++)
            {
                if (string.IsNullOrEmpty(arr[i]) == true)
                {
                    listView1.Items.Add(" ");
                }
                else
                {
                    listView1.Items.Add(prodString(arr[i],arr2[i]));
                }
            }
        }

        public void Prezztot(string [] arr2)
        {
            listView1.Items.Clear();

            int a = 0;
            int x = 0;

            int dim=100;


            for(int i=0;i<dim;i++)
            {
                if (arr2[i] != "")
                {

                    x = Int32.Parse(arr2[i]);

                    a = a + x;
                }
                else
                {
                    dim = 0;
                }

            }

            listView1.Items.Add("Prezzo totale = " + a);

        }

        public int perc()
        {


        }


        public string prodString(string p,string c)
        {
            return "Nome: " + p + " prezzo: " + c;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Visualizza_Click(object sender, EventArgs e)
        {
            aggiornaVista(dim);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modificato_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
