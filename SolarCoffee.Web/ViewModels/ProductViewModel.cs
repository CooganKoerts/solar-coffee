using System;

namespace SolarCoffee.Web.ViewModels {
    /// <summary>
    ///     Product entity DTO
    /// </summary>
    public class ProductViewModel {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsArchived { get; set; }
    }
}

/*
    View Models can also be referred to as 'Data Transfer Objects' or DTOs.
    This is used as a 'container' for data passed around the app in various places
*/