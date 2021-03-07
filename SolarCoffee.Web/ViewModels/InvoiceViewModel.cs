using System;
using System.Collections.Generic;

namespace SolarCoffee.Web.ViewModels {  
    /// <summary>
    /// View model for open SalesOrders
    /// </summary>
    public class InvoiceViewModel {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int CustomerId { get; set; }
        public List<SalesOrderItemViewModel> LineItems { get; set; }
    }
}