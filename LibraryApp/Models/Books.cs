namespace LibraryApp.Models
{
    public class Books
    {
         public int Id { get; set; }    
        public string Title { get; set; }
        public string SubTittle { get; set; }
        public string Synopsis { get; set; }
        public string PublicshDate { get; set; }
        public ICollection <Authors> Authors { get; set; }
    }
}
