using LibraryWepAPI.Models;

namespace LibraryWepAPI.Repository
{
    public interface IBookRepsitory
    {
        List<Boook> GetAll();
        Boook GetById(int id);
        void Add(Boook b);
        void Update(int id, Boook newBook);
        void remove(int id);

    }
}
