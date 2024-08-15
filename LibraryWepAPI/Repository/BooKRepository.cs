using LibraryWepAPI.Models;

namespace LibraryWepAPI.Repository
{
    public class BooKRepository : IBookRepsitory
    {
        DBEntity context;

        public BooKRepository(DBEntity Context)
        {
            context = Context;
        }
        public List<Boook> GetAll()
        {
           return context.Boooks.ToList();
        }
        public Boook GetById(int id)
        {
            return context.Boooks.FirstOrDefault(b=>b.Id==id);
        }
        public void Add(Boook b)
        {
            context.Boooks.Add(b);
            context.SaveChanges();
        }
        public void Update(int id, Boook newBook)
        {
            Boook oldBook = GetById(id);
            if (oldBook != null)
            {
                oldBook.Title = newBook.Title;
                oldBook.Auther = newBook.Auther;
                oldBook.ISBN = newBook.ISBN;
                oldBook.publicationYear = newBook.publicationYear;
                context.SaveChanges();
            }
        }
        public void remove(int id)
        {
            context.Boooks.Remove(GetById(id));
            context.SaveChanges();
        }

    }   
}
