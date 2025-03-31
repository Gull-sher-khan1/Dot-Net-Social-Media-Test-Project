//using Social_Media.Utils;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media
{
    public partial class Person
    {
        public Person FindByName(LinqToSqlDataClassesDataContext dataContext, string name)
        {
            return dataContext.Persons.First((p) => p.Name.Equals(name));
        }

        public bool Exists(LinqToSqlDataClassesDataContext dataContext)
        {
            return dataContext.Persons.Where(p => p.Name.Equals(Name) &&
                p.Password.Equals(Password)).Any();
        }
    }
}
