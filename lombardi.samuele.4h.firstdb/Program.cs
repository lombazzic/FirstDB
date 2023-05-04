using SQLite;



Console.WriteLine("Hello, DBWorld!");

SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtist = cn1.Query<Artist>("select * from artists");

Console.WriteLine($"In questa tabella ci sono {tblArtist.Count} record" );



// Fine del main --- inizio delle dichiarazioni ---
public class Artist
{
    public int ArtistId{ get; set; }
    public string Name{ get; set; }
}