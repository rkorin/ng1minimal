using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public PersonContext() :  base(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=PeopleContext-20161114; Integrated Security=True; MultipleActiveResultSets=True; AttachDbFilename=|DataDirectory|PeopleContext-20161114123310.mdf")
            //base("name=PersonContext")
        {
        }

        public System.Data.Entity.DbSet<Person> Persons { get; set; }
        public System.Data.Entity.DbSet<PersonImage> PersonImages { get; set; }
    }
}
