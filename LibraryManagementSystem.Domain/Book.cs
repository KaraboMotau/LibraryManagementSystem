using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Domain
{
    public class Book
    {
        private string title;
        private string author;
        private string isbn;
        private string publicationYear;

        public int Id { get; set; }
       
        [Required]
        [Display(Name = "Title")]
        public string Title 
        { 
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        [Required]
        [Display(Name = "Author")]
        public string Author 
        { 
            get
            {
                return author;
            }
            set
            {
              author = value;
            }
        }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of birth")] public DateTime PublicationYear  
        { 
            get
            {   return DateTime.Parse(publicationYear); 
            }
            set
            {
                publicationYear = value.ToString("yyyy");
            }
        }

        [Required(ErrorMessage = "ISBN")]
        public string ISBN 
        { 
            get
            {
                               return isbn;
            }
            set
            {                                
                isbn = value;
            }
        }
    }
}
