using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaBiblioteca
{
    public static class Seeder
    {
        private static string[] nome = { "Paolo", "Luca", "Giovanna" };
        private static string[] cognome = { "Rossi", "Alti", "Bassi" };
        private static string[] codiceFiscale = { "eniub4fb8", "cnenci44349" };
        private static string[] Nascita = { "03/04/2000 21:00:35", "10/12/1998 00:00:00" , "03/10/1994 00:00:00" };
        private static string[] titolo = { "La montagna", "La Luna", "Gioia" };
        private static string[] autore = { "A", "B", "C" };
        private static string[] ISBN = { "1234", "343422", "43232" };


        private static Random rnd = new Random();

        public static Libro generateLibro()
        {

            string _titolo = titolo[rnd.Next(0, titolo.Length)];
            string _autore = autore[rnd.Next(0, autore.Length)];
            string _ISBN = ISBN[rnd.Next(0, ISBN.Length)];
            Libro libro = new Libro(_titolo, _autore, _ISBN);
            return libro;
        }

        public static Utente generateUtente()
        {
            string _nome = nome[rnd.Next(0, nome.Length)];
            string _cognome = cognome[rnd.Next(0, cognome.Length)];
            string _codiceFiscale = codiceFiscale[rnd.Next(0, codiceFiscale.Length)];
            string _dataNascita = Nascita[rnd.Next(0, Nascita.Length)];
            Utente utente = new Utente(_nome, _cognome, _codiceFiscale, _dataNascita);
            return utente;
        }
    }
}
