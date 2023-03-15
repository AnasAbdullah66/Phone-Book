using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PhoneBook.Contact
{
    public class ContactInfo
    {
        public string Name { get; set; }
        public int ContactNumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Relationship { get; set; }
        public string Address { get; set; }
        public ImageSource ImageSrc { get; set; }
        public string Picture { get; set; }
    }
}
