using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaBiblioteca
{
    public class Utente
    {
        private string _nome;
        public string nome { get; set; } 

        private string _cognome;
        public string cognome { get; set; }

        private string _codiceFiscale;
        public string codiceFiscale { get; set; }

        private DateTime _dataNascita;
        public DateTime dataNascita { get; set; }

        private List<Libro> _libriPresi; //lista di libri dell'utente
        public List<Libro> libriPresi { get; set; }

        //VEDERE PER DATA DI NASCITA
        public Utente(string nome, string cognome, string codiceFiscale, string dataNascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.codiceFiscale = codiceFiscale;
            this.dataNascita = DateTime.Parse(dataNascita); //prende una data di nascita e ti restituisce il datetime corrispondente 
            this.libriPresi = new List<Libro>();
        }

        public string describe()
        {
            string output = "Nome: " + nome + "\r\n";
            output += "Cognome: " + cognome + "\r\n";
            output += "Data di nascita: " + dataNascita + "\r\n";
            output += "Codice Fiscale: " + codiceFiscale + "\r\n";
            output += "Numero di libri presi in prestito: " + libriPresi.Count + "\r\n"; //numero libri appartenenti alla lista libri dell'utente
            output += describeLibri(); //descrizione libri presi

            return output;
        }

        public string describeLibri()
        {
            string output = "Libri in prestito: " + "\r\n";
            
            foreach (Libro libro in libriPresi)
            {
                output += libro.describe(); //descrive ogni libro dell'utente
            }
            output += "\r\n";
            return output;
        }

        public override string ToString()
        {
            return (nome + " " + cognome + " " ).ToString();
        }

    }
}
