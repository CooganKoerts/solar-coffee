namespace SolarCoffee.Web.ViewModels {
    /// <summary>
    /// View model for a products inventory
    /// </summary>    
    public class ProductInventoryViewModel {
        public int Id { get; set; }
        public int QuantityOnHand { get; set; }
        public int IdealQuantity { get; set; }
        public ProductViewModel Product { get; set; }
    }
}