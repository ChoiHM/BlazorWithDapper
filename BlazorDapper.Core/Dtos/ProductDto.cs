using Dapper.Contrib.Extensions;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorDapper.Core.Dtos
{
    [Dapper.Contrib.Extensions.Table("product")]
    public class ProductDto
    {
        [Dapper.Contrib.Extensions.Key]
        public int Idx { get; set; }

        [Required]
        public string? Area_Nm { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}