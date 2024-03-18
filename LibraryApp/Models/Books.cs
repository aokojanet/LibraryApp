namespace LibraryApp.Models
{
	public class Books
	{ 
		public int Id { get; set; }
		public string Title { get; set; }
		public string SubTittle { get; set; }
		public string Synopsis {  get; set; }
		public DateTime PublishDate { get; set; }
		public Authors Authors { get; set; }
	}
}
