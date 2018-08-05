using Repository.Interface;
using System;

namespace SqlRepository
{
    public class MySqlRepository : IRepository
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
            return "SQL Repostiory";
        }    
    }
}
