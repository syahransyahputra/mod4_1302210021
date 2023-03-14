public class kodeBuah
{

    public enum buah { apel, aprikot, alpukat, pisang, paprika, blackberry, ceri, kelapa, jagung };

    public static string getKodeBuah(buah BUAH)
    {
        string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
        return kodeBuah[(int)BUAH];
    }
}
