using System;

namespace biblioteca2
{
    public interface IUtente
    {
        string Id { get; set; }
        int AnnoIscrizione { get; set; }
        string Denominazione { get; }
    }

    public class Persona : IUtente
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get { return Id + " " + Nome + " " + Cognome; }
        }
    }


    public class Organizzazione : IUtente
    {
        public string RagioneSociale { get; set; }
        public string Id { get; set; }
        public int AnnoIscrizione { get; set; }
        public string Denominazione
        {
            get { return Id + " " + RagioneSociale; }
        }
    }

    public class Biblioteca
    {
        static IUtente[] utenti;

        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Id = "0001";
            persona.Nome = "Mario";
            persona.Cognome = "Rossi";
            persona.AnnoIscrizione = 2016;

            Organizzazione org = new Organizzazione();
            org.Id = "0002";
            org.RagioneSociale = "Grandi Lettori SRL";
            org.AnnoIscrizione = 2010;

            utenti = new IUtente[] { persona, org };

            stampaUtenti();
        }

        static void stampaUtenti()
        {
            foreach (IUtente ute in utenti)
            {
                Console.WriteLine(ute.Denominazione);
            }
        }
    }
}