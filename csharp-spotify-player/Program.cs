// See https://aka.ms/new-console-template for more information

using csharp_spotify_player;

List<IContenutoRiproducibile> Riproduzione = new List<IContenutoRiproducibile>
{
    new Brano ("I kissed a girl", "Katy Perry", 3.2, "Pop", 300000),
    new Brano ("Psycho Killer", "Talking Heads", 4.32, "Rock", 273000),
    new Brano ("Pull the trigger", "Russ", 2.53, "Rap", 570000),
    new Podcast ("Roberto Bolle balla" ,"Muschiop Selvaggio" ,18.42, "Gossip, Sport", 30000),
    new Podcast ("Gerry SCotti non in tv", "Muschio Selvaggio", 23.30, "Gossip", 57235),
    new Podcast ("Velocissima chiacchera con Charles Leclerc", "Muschio Selvaggio", 52.36, "Gossip", 12236)
};

foreach (var contenutodariprodurre in Riproduzione)
{
    Console.WriteLine(contenutodariprodurre);
}

foreach (var contenutodariprodurre in Riproduzione)
{
    contenutodariprodurre.Play();
}

foreach (var contenutodariprodurre in Riproduzione)
{
    Console.WriteLine(contenutodariprodurre);
}
