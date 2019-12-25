using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreDependencyInjection.Interfaces;

namespace NetCoreDependencyInjection.Services
{
    public class BookSql : IBook
    {
        public string GetBooks()
        {
            return "sql book";
        }
    }
}
