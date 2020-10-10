using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        //[HttpGet]
        //public string Get()
        //{
        //    return "Lots of products";
        //}

        //[HttpGet("{id}")]
        //public string GetById(int id, [FromQuery] bool isActive)
        //{
        //    return $"Lots of products: {id}, status: {isActive}";
        //}        

        
        [HttpGet]
        public string GetByObject([FromQuery] ProductDTO productDTO)
        {
            return $"product id: {productDTO.Id}, name: {productDTO.Name}";
        }

        [HttpPost]
        public IActionResult Post(ProductDTO productDTO)
        {           

            return Ok($"product id: {productDTO.Id}, name: {productDTO.Name}");
        }
    }   
    
    public class ProductDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The name has to be less than 10 char long.")]
        public string Name { get; set; }

        [ReleasedDateInPast]
        public DateTime ReleasedDate { get; set; }
    }
    
    public class ReleasedDateInPast: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var productDTO = (ProductDTO)validationContext.ObjectInstance;

            if (productDTO.ReleasedDate >= DateTime.Today) return new ValidationResult("The product's release date has to be in the past.");

            return ValidationResult.Success;
        }
    }
}
