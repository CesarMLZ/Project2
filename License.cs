using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class License
    {
        public string start { get; set; }
        public string end { get; set; }
        public bool status { get; set; }
        public string type { get; set; }
        public Person person { get; set; }
        public int id => person.id;
    }
}