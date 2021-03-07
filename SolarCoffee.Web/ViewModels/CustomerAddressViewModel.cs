using System;
using System.ComponentModel.DataAnnotations;

namespace SolarCoffee.Web.ViewModels {
    /// <summary>
    /// View model for customer's addresses
    /// </summary>
    public class CustomerAddressViewModel {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}