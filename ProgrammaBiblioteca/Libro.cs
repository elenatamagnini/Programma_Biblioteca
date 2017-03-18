using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammaBiblioteca
{
    public class Libro
    {
        private string _titolo;
        public string titolo { get; set; }

        private string _autore;
        public string autore { get; set; }

        private string _ISBN;
        public string ISBN { get; set; }

        enum genere { giallo, fantasy, romanzo, rosa, fumetto, rivista, avventura, enciclopedico, fantascienza };

        private bool _prestato;
        private bool prestato { get; set; }

        public Libro(string titolo, string autore, string ISBN)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.ISBN = ISBN;
        }

        public override string ToString()
        {
            return titolo + " " + ISBN;
        }

        public string describe()
        {
            string output = "Il titolo è " + titolo + "\r\n";
            output += "L'autore è " + autore + "\r\n";
            output += "Il codice ISBN è " + ISBN + "\r\n";
            if (prestato) output += "Il libro è stato prestato";  //se prestato è true 
            else output += "Il libro è disponibile per il prestito"; //se prestato è false

            return output;
        }

        public bool presta(Utente utente)
        {
            if (utente.libriPresi.Count < 6 && prestato == false) {
                utente.libriPresi.Add(this); //aggiungi il libro alla lista libri dell'utente
                prestato = true;
                MessageBox.Show("Libro prestato!"); 
                return true;
            }
            else {
                MessageBox.Show("Non è possibile concludere il prestito");
                return false;
            }
        }
    }
}
