using System;

namespace biblioteca
{
    public class Utente
    {
        private string id;
        private string nome;
        private string cognome;
        private int annoIscrizione;

        public Utente(string id, string nome, string cognome, int annoIscrizione)
        {
            this.id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.annoIscrizione = annoIscrizione;
        }

        public string Denominazione()
        {
            return this.nome + " " + this.cognome;
        }
    }

    public class Libro
    {
        private string id;
        private string titolo;
        private string autore;
        private Utente utente;

        public Libro(string id, string titolo, string autore)
        {
            this.id = id;
            this.titolo = titolo;
            this.autore = autore;
            this.utente = null;
        }

        public string Descrizione()
        {
            return this.titolo + " di " + this.autore;
        }

        public void prestito(Utente utente)
        {
            if (this.utente != null)
            {
                Console.WriteLine("Il libro è già in prestito a " + this.utente.Denominazione());
            }
            else
            {
                this.utente = utente;
                Console.WriteLine("Il libro " + this.Descrizione() + " è stato prestato a " + utente.Denominazione());
            }
        }

        public void Restituzione()
        {
            if (this.utente != null)
            {
                Console.WriteLine("Il libro " + this.Descrizione() + " è stato restituito da " + this.utente.Denominazione());
                this.utente = null;
            }
            else
            {
                Console.WriteLine("Il libro " + this.Descrizione() + " non era in prestito.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Utente utente1 = new Utente("U001", "Mario", "Rossi", 2020);
            Console.WriteLine(utente1.Denominazione());

            Utente utente2 = new Utente("U002", "Luigi", "Verdi", 2021);
            Console.WriteLine(utente2.Denominazione());

            Libro libro1 = new Libro("L001", "Il Signore degli Anelli", "J.R.R. Tolkien");
            Console.WriteLine(libro1.Descrizione());

            Libro libro2 = new Libro("L002", "1984", "George Orwell");
            Console.WriteLine(libro2.Descrizione());

            libro1.prestito(utente1);
            libro1.prestito(utente2); // Tentativo di prestito quando il libro è già in prestito
            libro1.Restituzione();
            libro1.prestito(utente2); // Ora il prestito dovrebbe riuscire

            libro2.prestito(utente1);
            libro2.Restituzione();
        }
    }
}