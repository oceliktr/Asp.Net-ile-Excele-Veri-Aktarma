using System.Collections.Generic;

public class OgrenciInfo
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string Cinsiyeti { get; set; }
    public int Sinifi { get; set; }
    public int Numarasi { get; set; }
    
    public OgrenciInfo()
    {

    }
    private OgrenciInfo(string adi, string soyadi, string cinsiyeti, int sinifi, int numarasi)
    {
        Adi = adi;
        Soyadi = soyadi;
        Cinsiyeti = cinsiyeti;
        Sinifi = sinifi;
        Numarasi = numarasi;
    }
    public List<OgrenciInfo> OgrenciListesi()
    {
        List<OgrenciInfo> ogr = new List<OgrenciInfo>
        {
            new OgrenciInfo("Büşra", "Tepe", "Kız", 8,687),
            new OgrenciInfo("Erol", "Çamurlu", "Erkek", 8,799),
            new OgrenciInfo("Ayşe", "Esgin", "Kız", 8,541),
            new OgrenciInfo("Tülin", "İmrek", "Kız", 8,684),
            new OgrenciInfo("Samet", "Karaçelik", "Erkek", 8,726),
            new OgrenciInfo("Muazzez", "Gögüs", "Kız", 8,781),
            new OgrenciInfo("Elif", "Can öztürk", "Kız", 8,773),
            new OgrenciInfo("Ali", "Doğan", "Erkek", 8,716),
            new OgrenciInfo("Sernur", "Taş şahin", "Kız", 8,586),
            new OgrenciInfo("Salih", "Meray", "Erkek", 8,571)
        };

        return ogr;
    }
}