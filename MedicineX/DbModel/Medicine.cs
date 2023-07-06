using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicineX.DbModel
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime ExpTime { get; set; }
        public string ImageUrl { get; set; }
        public int Status { get; set; }
    }
}
