using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambirasio_Cassaforte
{
    internal class Cassaforte
    {
        private int numeroMatricola;
        private int pin = 0;
        private string produttore;
        private string modello;
        private char stato = 'A';
        private int tentativi;
        private string codiceDiSblocco;

        public Cassaforte(int numeroMatricola, string codiceDiSblocco, string produttore, string modello)
        {
            this.numeroMatricola = numeroMatricola;
            this.codiceDiSblocco = codiceDiSblocco;
            this.produttore = produttore;
            this.modello = modello;
        }

        public int NumeroMatricola { get { return numeroMatricola; } }
        public int Pin { get { return pin; } set { pin = value; } }
        public string Produttore { get {  return produttore; } }
        public string Modello { get {  return modello; } }
        public char Stato { get {  return stato; } set { stato = value; } }
        public int Tentativi { get {  return tentativi; } set { tentativi = value; } }
        public string CodiceDiSblocco { get { return codiceDiSblocco; } set { codiceDiSblocco = value; } }

        public void Imposta(int nuovoPin)
        {
            if (nuovoPin.ToString().Length != 5)
            {
                MessageBox.Show("Il pin inserito non è valido");
                return;
            }
            if (Stato != 'A') return;
            Pin = nuovoPin;
        }

        public void Apri(int tentativo)
        {
            if(Tentativi < 4) 
            {
                Tentativi++;
                if (stato == 'B') return;

                if (tentativo.ToString().Length != 5) 
                { 
                    MessageBox.Show("Il pin inserito non è valido"); 
                    return; 
                }
                if (tentativo == Pin)
                {
                    Stato = 'A'; 
                    Tentativi = 0;
                    return;
                }
            }
            else Stato = 'B';
            
        }

        public void Chiudi()
        {
            if (Stato != 'A') return;
            if (Pin == 0)
            {
                MessageBox.Show("Imposta prima un pin!");
                return;
            }
            Stato = 'C';
        }

        public void Sblocca(string tentativo)
        {
            if (Stato != 'B') return;
            if (tentativo.ToString().Length != 12) return;
            if (CodiceDiSblocco != tentativo) return;
            Stato = 'C';
            Tentativi = 0;

        }
        
    }
}
