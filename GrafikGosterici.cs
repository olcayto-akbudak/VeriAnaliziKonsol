namespace VeriAnalizKonsol
{
    public static class GrafikGosterici
    {
        public static void Ciz(List<SaleRecord> records)
        {
            var toplamlar = records
                .GroupBy(r => r.Product)
                .Select(g => new { Urun = g.Key, Toplam = g.Sum(x => x.Amount) })
                .OrderByDescending(x => x.Toplam);

            Console.WriteLine("\n--- URUN SATIS GRAFIGI ---");
            foreach (var item in toplamlar)
            {
                int barUzunlugu = (int)(item.Toplam / 100);
                Console.WriteLine($"{item.Urun.PadRight(15)} | {new string('#', barUzunlugu)} {item.Toplam} TL");
            }
        }
    }
}
