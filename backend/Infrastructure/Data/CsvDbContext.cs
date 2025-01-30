using CsvHelper;
using CsvHelper.Configuration;
using Domain.Entities;
using System.Globalization;

namespace Infrastructure.Data
{
    public class CsvDbContext
    {
        private readonly string _csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "CsvFiles");

        public List<Bill> Bills { get; private set; }
        public List<Legislator> Legislators { get; private set; }
        public List<Vote> Votes { get; private set; }
        public List<VoteResult> VoteResults { get; private set; }

        public CsvDbContext()
        {
            Bills = LoadCsv<Bill>("bills.csv");
            Legislators = LoadCsv<Legislator>("legislators.csv");
            Votes = LoadCsv<Vote>("votes.csv");
            VoteResults = LoadCsv<VoteResult>("vote_results.csv");
        }

        private List<T> LoadCsv<T>(string fileName)
        {
            var filePath = Path.Combine(_csvPath, fileName);
            if (!File.Exists(filePath))
                return new List<T>();

            using var reader = new StreamReader(filePath);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true, 
                
            };

            using var csv = new CsvReader(reader, config);
            return csv.GetRecords<T>().ToList();
        }
    }
}
