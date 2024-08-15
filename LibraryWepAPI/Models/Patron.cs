namespace LibraryWepAPI.Models
{
    public class Patron
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public virtual List<Boook>? Boooks { get; set; }
    }
}
