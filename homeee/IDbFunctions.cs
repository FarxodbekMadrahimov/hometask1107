using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLessons
{
    internal interface IDbFunctions
    {
        public void Add();
        public void Update();
        public void DeleteAll();
        public void DeleteById ();
        public void DeleteByName ();
        public void GetAll();
        public void GetById ();
        public void GetByName ();
    }
}
