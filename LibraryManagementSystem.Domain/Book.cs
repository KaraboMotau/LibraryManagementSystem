using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Domain
{
    public class Book
    {
        private string title;
        private string author;
        private string isbn;
        private DateTime publicationYear;

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
        [Display(Name = "Publication Year")] 
        public DateTime PublicationYear  
        { 
            get
            {
                return publicationYear;
            }
            set
            {
                publicationYear = value;
            }
        }

        [Required(ErrorMessage = "ISBN")]
        [RegularExpression(@"^[\d-]+$", ErrorMessage = "Only numbers and hyphens are allowed.")]
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
