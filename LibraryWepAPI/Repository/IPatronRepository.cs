using LibraryWepAPI.Models;

namespace LibraryWepAPI.Repository
{
    public interface IPatronRepository
    {
        List<Patron> GetAll();
        Patron GetById(int id);
        void Add(Patron p);
        void Update(int id, Patron newPatron);
        void remove(int id);
    }
}
