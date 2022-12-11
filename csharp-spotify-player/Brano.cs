using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    public class Brano : IContenutoRiproducibile
    {
        //ATTRIBUTI
        private string nomeBrano;
        private string nomeAutore;
        private double durataBrano;
        private string genereBrano;
        private int streamingBrano;

        //COSTRUTTORI
        public Brano()
        {

        }

        public Brano(string nomeBrano, string nomeAutore, double durataBrano, string genereBrano, int streamingBrano)
        {
            this.nomeBrano = nomeBrano;
            this.nomeAutore = nomeAutore;
            this.durataBrano = durataBrano;
            this.genereBrano = genereBrano;
            this.streamingBrano = streamingBrano;
        }

        //GETTER
        public string getnomeBrano()
        {
            return this.nomeBrano;
        }

        public string getnomeAutore()
        {
            return this.nomeAutore;
        }

        public double getdurataBrano()
        {
            return this.durataBrano;
        }

        public string getgenereBrano()
        {
            return this.genereBrano;
        }

        public int getstreamingBrano()
        {
            return this.streamingBrano;
        }

        //SETTER
        //METODI PRIVATI
        //METODI PUBBLICI

        public void Play()
        {
            streamingBrano++;
            Console.WriteLine("Riproduzione del brano " + nomeBrano + " di " + nomeAutore + "\n");
        }
        public void Stop()
        {
            Console.WriteLine("Riproduzione del brano " + nomeBrano + " di " + nomeAutore + "\n");
        }
        public void Pause()
        {
            Console.WriteLine("Riproduzione del brano " + nomeBrano + " di " + nomeAutore + "\n");
        }


        public override string ToString()
        {
            string obj = $"Nome: {nomeBrano}\n" +
                         $"Nome Autore: {nomeAutore}\n" +
                         $"Durata: {durataBrano}\n" +
                         $"Genere: {genereBrano}\n" +
                         $"Streaming: {streamingBrano}\n";
            return obj;
    }

    }
}
