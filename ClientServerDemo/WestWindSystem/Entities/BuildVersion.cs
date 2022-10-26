using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WestWindSystem.Entities
{
    [Table(name:"BuildVersion")]
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
