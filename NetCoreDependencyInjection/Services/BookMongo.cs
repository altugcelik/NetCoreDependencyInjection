using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreDependencyInjection.Interfaces;

namespace NetCoreDependencyInjection.Services
{
    public class BookMongo : IBook
    {
        public string GetBooks()
        {
            return "book mongo";
        }
    }
}
