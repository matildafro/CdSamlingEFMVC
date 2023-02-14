using System.ComponentModel.DataAnnotations;

namespace CdSamling.Models
{

    //klass cd-samling
    public class Collection
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Albums titel")]
        public string? Title { get; set; }

        public int? Release { get; set; }

        //läser in nyckel artistId
        public int? ArtistId { get; set; }
        //hämtar hela klassen
        public Artist? Artist { get; set; }

       
    }
    //klass artist
    public class Artist
    {
        
        public int Id { get; set; }
        [Required]
        [Display(Name = "Namn på artist")]
        public string? Name { get; set; }

    }

    //klass utlåning av skivor
    public class Rent
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Utlånad till")]
        public string? RentByName { get; set; }

        
        [Display(Name = "Datum")]

        [DataType(DataType.Date)]
        public DateTime RentdDate { get; set; }

        public int? CollectionId { get; set; }

        public Collection? Collection { get; set; }


    }

    
}
