using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        GercekMusteri musteri1= new GercekMusteri();
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Engin";
        musteri1.Soyadi = "Demiroğ";
        musteri1.TcNo = "123424214";

        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "54321";
        musteri2.SirketAdi = "kodlama.io";
        musteri2.VergiNo = "123452131";

        Musteri musteri3 = new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2);


    }
}