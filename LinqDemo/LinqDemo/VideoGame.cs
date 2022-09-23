using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    record VideoGame(
            string Title,
            string Platform,
            double Price,
            Guid WebCode
        );
    
}
