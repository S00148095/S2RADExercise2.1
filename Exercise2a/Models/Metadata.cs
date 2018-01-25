using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise2a.Models
{
    public class CustomerMetadata
    {
        public int Id;

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(25, MinimumLength = 2)]
        public string FirstName;
        
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(25, MinimumLength = 2)]
        public string LastName;
        
        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress]
        public string Email;
    }

    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer { }

    public class ProductMetadata
    {
        public int Id;

        [Required(ErrorMessage = "Name is required")]
        [StringLength(25, MinimumLength = 2)]
        public string Name;

        [Required(ErrorMessage = "Cost is required")]
        public decimal Cost;

        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity;
    }

    [MetadataType(typeof(ProductMetadata))]
    public partial class Product { }

    public class OrderMetadata
    {
        public int Id;

        [Required(ErrorMessage = "Customer ID is required")]
        public int CustomerID;

        [Required(ErrorMessage = "Product ID is required")]
        public int ProductID;

        [Required(ErrorMessage = "Order Quantity is required")]
        public int OrderQuantity;
    }

    [MetadataType(typeof(OrderMetadata))]
    public partial class Order { }
}