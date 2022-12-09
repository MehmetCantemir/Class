namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1= new Calisan();
            calisan1.Ad = "Mehmet";
            calisan1.SoyAd = "Cantemir";
            calisan1.No = 21321414;
            calisan1.Departman = "BT";
            calisan1.CalisanBilgileri();
        }
             
    }
    class Calisan
    {
        public string Ad;

        public string SoyAd;

        public int No;

        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı :{0} ",Ad);
            Console.WriteLine("Çalışan SoyAdı :{0} ", SoyAd);
            Console.WriteLine("Çalışan No :{0} ", No);
            Console.WriteLine("Çalışan Departman :{0} ", Departman);

        }

    }
}