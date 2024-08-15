using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWepAPI.Models
{
    public class Boook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Auther { get; set; }
        public int publicationYear { get; set; }
        public int ISBN { get; set; }
        [ForeignKey("Patron")]
        public int? PatronId { get; set; }
        public virtual Patron? Patron { get; set; }
    }
}
