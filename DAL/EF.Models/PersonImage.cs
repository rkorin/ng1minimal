using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    [Table("PeopleImages")]
    public class PersonImage
    {
        [Key]
        public int Id { get; set; }

        byte[] ImageStream { get; set; }
    }
}
