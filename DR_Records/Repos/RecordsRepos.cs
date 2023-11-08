using DR_Records.Models;

namespace DR_Records.Repos
{
    public class RecordsRepos
    {
        private static int _nextId = 1;
        private int Id = _nextId++;

        public List<Record> Records = new List<Record>()
        {   
            new Record("Enter Sandman","Metalica",180,2010),
            new Record("Thriller","Michael Jackson", 70,2008),
            new Record("Køb bananer","Kim Larsen", 60, 2007),
        };

        public List<Record> GetAll()
        { 
            List<Record> Result = new List<Record>(Records);
            return Result;
        }
        
    }
}
