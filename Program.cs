using VeriAnalizKonsol;

string filePath = "sales.csv";
if (!File.Exists(filePath))
{
    Console.WriteLine($"Dosya bulunamadi: {filePath}");
    return;
}

var records = CsvReader.ReadCsv(filePath);

Console.WriteLine($"Toplam Satis Kaydi: {records.Count}");
Console.WriteLine($"Toplam Gelir: {records.Sum(r => r.Amount)} TL");
Console.WriteLine($"Ortalama Satis: {records.Average(r => r.Amount):0.00} TL");

var maxSale = records.OrderByDescending(r => r.Amount).First();
Console.WriteLine($"En Yuksek Satis: {maxSale.CustomerName} - {maxSale.Product} - {maxSale.Amount} TL");

Console.WriteLine("\n--- FILTRELEME ---");
Console.WriteLine("1 - Urune gore filtrele");
Console.WriteLine("2 - Tarihe gore filtrele");
Console.Write("Seciminiz: ");
var secim = Console.ReadLine();

if (secim == "1")
{
    Console.Write("Urun adi girin: ");
    var urun = Console.ReadLine();
    var filtreli = records.Where(r => r.Product.Equals(urun, StringComparison.OrdinalIgnoreCase)).ToList();

    foreach (var rec in filtreli)
        Console.WriteLine($"{rec.CustomerName} - {rec.Product} - {rec.Amount} TL");

    Console.WriteLine($"Toplam {filtreli.Count} kayit bulundu.");
}
else if (secim == "2")
{
    Console.Write("Tarih girin (yyyy-MM-dd): ");
    var tarihInput = Console.ReadLine();
    if (DateTime.TryParse(tarihInput, out DateTime tarih))
    {
        var filtreli = records.Where(r => r.SaleDate.Date == tarih.Date).ToList();
        foreach (var rec in filtreli)
            Console.WriteLine($"{rec.CustomerName} - {rec.Product} - {rec.Amount} TL");

        Console.WriteLine($"Toplam {filtreli.Count} kayit bulundu.");
    }
    else
    {
        Console.WriteLine("Gecersiz tarih formati!");
    }
}

GrafikGosterici.Ciz(records);
