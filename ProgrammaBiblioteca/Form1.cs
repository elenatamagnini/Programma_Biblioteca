using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammaBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Libro> libri = new List<Libro>();
        public List<Utente> utenti = new List<Utente>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //crea la ListBox e aggiunge lo stesso libro alla lista libri
            for (int i = 0; i < 20; i++) //ripete n volte il generateLibro
            {
                var libro = Seeder.generateLibro();
                listBox1.Items.Add(libro);
                libri.Add(libro);
            }

            for (int i = 0; i < 20; i++)
            {
                var utente = Seeder.generateUtente();
                listBox2.Items.Add(utente);
                utenti.Add(utente);
            }

            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //evento: quando SelectedIndex cambia
        {
            var l = libri[listBox1.SelectedIndex];
            textBox1.Text = l.describe();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var u = utenti[listBox2.SelectedIndex];
            textBox1.Text = u.describe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PRESTITO
            var u = utenti[listBox2.SelectedIndex];
            var l = libri[listBox1.SelectedIndex];

            l.presta(u);

            textBox1.Text = u.describe();
        }
    }
}
