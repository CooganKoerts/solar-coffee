using System;
using System.ComponentModel.DataAnnotations;

namespace SolarCoffee.Web.ViewModels {
    /// <summary>
    /// View model for a customer
    /// </summary>
    public class CustomerViewModel {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        [MaxLength(32)] public string FirstName { get; set; }
        [MaxLength(32)] public string LastName { get; set; }
        public CustomerAddressViewModel PrimaryAddress { get; set; }
    }
}
