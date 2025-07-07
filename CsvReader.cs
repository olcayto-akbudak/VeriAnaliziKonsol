using System.Globalization;

namespace VeriAnalizKonsol
{
    public static class CsvReader
    {
        public static List<SaleRecord> ReadCsv(string path)
        {
            var records = new List<SaleRecord>();
            var lines = File.ReadAllLines(path).Skip(1);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length < 4) continue;
                records.Add(new SaleRecord
                {
                    CustomerName = parts[0],
                    Product = parts[1],
                    SaleDate = DateTime.Parse(parts[2]),
                    Amount = decimal.Parse(parts[3], CultureInfo.InvariantCulture)
                });
            }

            return records;
        }
    }
}
