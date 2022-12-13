using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Project.Models.Base
{
    public class BaseEntity
    {
        [Key]

        // Generates a value when a row is inserted

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        // Generates a value when a row is inserted or updated
        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

        // Does not generate a value
        // [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
    }
}
