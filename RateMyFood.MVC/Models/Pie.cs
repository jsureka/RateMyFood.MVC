using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RateMyFood.MVC.Models
{
    public class Pie
    {
        public int PieId { get; set; }

        //[Remote("CheckIfPieNameAlreadyExists", "PieManagement", ErrorMessage = "That name already exists")]
        public string Name { get; set; }

        [MaxLength(100)]
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? AllergyInformation { get; set; }
        public decimal Price { get; set; }

        //[ValidUrl(ErrorMessage = "That's not a valid URL")]
        public string? ImageUrl { get; set; }

        //[ValidUrl(ErrorMessage = "That's not a valid URL")]
        public string? ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        //public virtual List<PieReview> PieReviews { get; set; }

        //public SugarLevel SugarLevel { get; set; }
        //public RecipeInformation RecipeInformation { get; set; }


    }
}
