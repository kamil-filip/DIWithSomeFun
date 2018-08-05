using Repository.Interface;
using System;

namespace CSVRepository
{
    public class MyCsvRepository : IRepository
    {
        public void Add(string toAdd)
        {
         
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public string Get()
        {
            return "CSV Repostiory";
        }
    }
}
