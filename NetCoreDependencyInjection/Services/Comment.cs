using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreDependencyInjection.Interfaces;

namespace NetCoreDependencyInjection.Services
{
    public class Comment : IComment
    {
        public string GetComments()
        {
            return "Frist Comment";
        }
    }
}
