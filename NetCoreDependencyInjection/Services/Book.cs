using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreDependencyInjection.Interfaces;

namespace NetCoreDependencyInjection.Services
{
    public class Book : IBook
    {
        //list çek
        public string GetBooks()
        {
            return "First entiy Book";
        }
    }
}
