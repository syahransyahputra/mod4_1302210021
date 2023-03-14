public class kodeBuah
{

    public enum buah { apel, aprikot, alpukat, pisang, paprika, blackberry, ceri, kelapa, jagung };

    public static string getKodeBuah(buah BUAH)
    {
        string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
        return kodeBuah[(int)BUAH];
    }

    
}

public class PosisiKarakteraGame
{
    //enum state { berdiri, terbang };

    public static void Main(string[] args)
    {
        Console.WriteLine("buah " + kodeBuah.buah.aprikot + " kode buah nya adalah " + kodeBuah.getKodeBuah(kodeBuah.buah.aprikot));
        Console.WriteLine("perintah: ");

        //state gerak = state.berdiri;
        string Perintah = "tombolS";

        while (Perintah == "tombolS" || Perintah == "tombolW")
        {
            //Console.WriteLine(gerak);
            Console.Write("Masukkan Perintah: ");
            Perintah = Console.ReadLine();

            if (Perintah == "tombolW")
            {
                Console.WriteLine("tombol arah atas di tekan");
                //gerak = state.terbang;
            }
            else if (Perintah == "tombolS")
            {
                Console.WriteLine("tombol arah bawah di tekan");
                //gerak = state.berdiri;
            }
        }
    }
}