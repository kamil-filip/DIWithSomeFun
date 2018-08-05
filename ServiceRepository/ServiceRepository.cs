using Repository.Interface;
using System;

namespace ServiceRepository
{
    public class ServiceRepository : IRepository
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
            return "Service Repostiory";
        }
    }

}
