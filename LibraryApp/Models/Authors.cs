namespace LibraryApp.Models
{
    public class Authors
    {
        public int AuthorsId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Education { get; set; }
        public ICollection<Books>? Books { get; set; }
    }
}
