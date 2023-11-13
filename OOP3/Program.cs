using OOP3;

internal class Program
{
    private static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager =new IhtiyacKrediManager();

        IKrediManager tasitKrediManager =new TasitKrediManager();

        IKrediManager konutKrediManager = new KonutKrediManager();

        BasvuruManager basvuruManager = new BasvuruManager();
        //basvuruManager.BasvuruYap(konutKrediManager);

        List<IKrediManager> krediler=new List<IKrediManager> { ihtiyacKrediManager,tasitKrediManager};
        basvuruManager.KrediOnBilgilendirmesiYap(krediler);

    }
}