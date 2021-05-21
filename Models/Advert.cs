using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.ViewModels;
using WpfApp1.Views;

namespace WpfApp1.Models
{   [Table("Adverts")]
    public class Advert
    {
        
        public DateTime dateOfPublished;
        public string author, content, nameOfAdvert,whoAddAdvert;
        public DateTime DateOfPublished
        {
            get
            {
                return dateOfPublished;
            }
            set
            {
                dateOfPublished = value;
            }
        }
        [Key]
        public int Id { get; set; }
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
        public string WhoAddAdvert
        {
            get
            {
                return whoAddAdvert;
            }
            set
            {
                whoAddAdvert = value;
            }
        }
        public string NameOfAdvert
        {
            get
            {
                return nameOfAdvert;
            }
            set
            {
                nameOfAdvert = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
  
        public Advert()
        {

        }
        public Advert(DateTime DateOfPublished, string Author, string Content,string NameOfAdvert,string WhoAddAdvert)
        {
            this.DateOfPublished = DateOfPublished;
            this.Author = Author;
            this.Content = Content;
            this.NameOfAdvert = NameOfAdvert;
            this.WhoAddAdvert = WhoAddAdvert;
        }
    }

    
}
