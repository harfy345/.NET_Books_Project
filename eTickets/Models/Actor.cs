using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

     
        public string ProfilePictureURL { get; set; }

   
        public String FullName { get; set; }

 
        public String Bio { get; set;}


        //Relation
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
