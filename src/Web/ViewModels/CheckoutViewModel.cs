using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class CheckoutViewModel
    {
        [Display(Name ="First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Street")]
        [Required]
        public string Street { get; set; }

        [Display(Name = "City")]
        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Display(Name = "State")]
        [Required]
        [MaxLength(60)]
        public string State { get; set; }

        [Display(Name = "Country")]
        [Required]
        [MaxLength(90)]
        public string Country { get; set; }

        [Display(Name = "Zip Code")]
        [MaxLength(5)]
        [RegularExpression("^[0-9]{5}$", ErrorMessage = "Invalid Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Card Holder")]
        [Required]
        [MaxLength(100)]
        public string CCName { get; set; }
        [Display(Name = "Credit Card Number")]
        [Required]
        [RegularExpression("^[0-9]{16}$",ErrorMessage = "Invalid Credit Card Number")]
        [MaxLength(16)]
        public string CCNumber { get; set; }
        [Display(Name = "CVV")]
        [Required]
        [RegularExpression("^[0-9]{3,4}$",ErrorMessage = "Invalid CVV")]
        [MaxLength(4)]
        public string CCCvv { get; set; }
        [Display(Name = "Expiration")]
        [RegularExpression("^[0-9]{2}/[0-9]{2}$", ErrorMessage = "Invalid Expiration Date")]
        [Required]
        [MaxLength(5)]
        public string CCExpiration { get; set; }

        public List<BasketItemViewModel> BasketItems { get; set; }

        [Display(Name = "Payment Total")]
        public decimal PaymentTotal { get; set; }

        public string BasketItemsJson { get; set; }

        public int BasketId { get; set; }

    }
}
