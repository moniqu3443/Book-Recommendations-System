namespace DefaultNamespace;

public class BookRepository
{
   //store where the books go
   private List <Book> _books = new List<Book>();
   
   //add books
   public void Add(Book book)
   {
      _books.Add(book);
   }
      
   //get all
   public List<Book> GetAll() 
   {
      return _books; 
   }
   
   //getByISBN
   public Book GetByISBN(string isbn)
   {
      //returns first book that matches ISBN
      return _books.Find(b => b.ISBN == isbn);
   }
}
