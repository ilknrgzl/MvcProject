using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CategoryID { get; set; }  // categori kısmı ile aynı ID bu ilişkileri kurabilmek için kullanılır
        public virtual Category Category { get; set; }  //categori sınıfında bir property oluşturdum sen benim headin sııfımla ilişkili olacaksın

        //category tründe bir property tanımlayarak aynı ilşkiyi burda da yaptık

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        public ICollection<Contact> Contects { get; set; }

        
        
    }
}
