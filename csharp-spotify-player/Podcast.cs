using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    public class Podcast : IContenutoRiproducibile
    {
        //ATTRIBUTI
        private string nomePodcast;
        private string nomeAutorePodcast;
        private double durataPodcast;
        private string generePodcast;
        private int streamingPodcast;



        //COSTRUTTORI
        public Podcast()
        {

        }

        public Podcast(string nomePodcast, string nomeAutorePodcast, double durataPodcast, string generePodcast, int streamingPodcast)
        {
            this.nomePodcast = nomePodcast;
            this.nomeAutorePodcast = nomeAutorePodcast;
            this.durataPodcast = durataPodcast;
            this.generePodcast = generePodcast;
            this.streamingPodcast = streamingPodcast;
        }

        //GETTER

        public string getnomePodcast()
        {
            return this.nomePodcast;
        }

        public string getnomeAutorePodcast()
        {
            return this.nomeAutorePodcast;
        }

        public double getdurataPodcast()
        {
            return this.durataPodcast;
        }

        public string getgenerePodcast()
        {
            return this.generePodcast;
        }

        public int getstreamingPodcast()
        {
           return this.streamingPodcast;
        }

        //SETTER
        //METODI PRIVATI
        private void DurataBrano()
        {

        }
        //METODI PUBBLICI

        public void Play()
        {
            streamingPodcast++;
            Console.WriteLine("Riproduzione del podcast " + nomePodcast + " di " + nomeAutorePodcast + "\n");
        }
        public void Stop()
        {
            Console.WriteLine("Riproduzione del podcast " + nomePodcast + " di " + nomeAutorePodcast + "\n");
        }
        public void Pause()
        {
            Console.WriteLine("Riproduzione del podcast " + nomePodcast + " di " + nomeAutorePodcast + "\n");
        }


        public override string ToString()
        {   
            string obj = $"Nome: {nomePodcast}\n" +
                         $"Nome Autore: {nomeAutorePodcast}\n" +
                         $"Durata: {durataPodcast}\n" +
                         $"Genere: {generePodcast}\n" +
                         $"Streaming: {streamingPodcast}\n";
            return obj;
        }
    }
}
