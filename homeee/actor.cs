using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLessons
{
    public class actor
    {
        public int actor_id { get;set; }
        public string first_name { get;set; }
        public string last_name { get;set;}
        public DateTime last_update { get;set; }
    }
}
