using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
     class Employee
     {
         private string Name;
         private string Surname;
         private string Post;
         private int Exp;
         public Employee(string n, string s)
         {
            Name = n;
            Surname = s;
         }
        public string name
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
            }
        }
        public string surname
        {
            set
            {
                Surname = value;
            }
            get
            {
                return Surname;
            }
        }
        public string post
        {
            set
            {
                Post = value;
            }
            get
            {
                return Post;
            }
        }
        public int exp
        {
            set
            {
                Exp = value;
            }
            get
            {
                return Exp;
            }
        }
    }
}
