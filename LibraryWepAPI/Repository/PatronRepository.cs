using LibraryWepAPI.Models;

namespace LibraryWepAPI.Repository
{
    public class PatronRepository : IPatronRepository
    {
        DBEntity context;

        public PatronRepository(DBEntity Context)
        {
            context = Context;
        }
        public List<Patron> GetAll()
        {
            return context.Patrons.ToList();
        }
        public Patron GetById(int id)
        {
            return context.Patrons.FirstOrDefault(b => b.Id == id);
        }
        public void Add(Patron newPatron)
        {
            context.Patrons.Add(newPatron);
            context.SaveChanges();
        }
        public void Update(int id, Patron newPatron)
        {
            Patron oldPatron = GetById(id);
            if (oldPatron != null)
            {
                oldPatron.Name = newPatron.Name;
                oldPatron.Address = newPatron.Address;
                oldPatron.PhoneNumber = newPatron.PhoneNumber;
                oldPatron.Email = newPatron.Email;
                context.SaveChanges();
            }
        }
        public void remove(int id)
        {
            context.Patrons.Remove(GetById(id));
            context.SaveChanges();
        }
    }
}
