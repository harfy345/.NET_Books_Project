using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

       
        public string ProfilePictureURL { get; set; }

     
        public String FullName { get; set; }

    
        public String Bio { get; set; }

        //Relation
        public List<Movie> Movies { get; set; }

    }
}
