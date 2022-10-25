using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindSystem.Entities
{
    public class BuildVersion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Major { get; set; }
        public int Minor { get;set; }
        public int Build { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
