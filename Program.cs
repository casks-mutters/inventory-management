// Program.cs

class Program
{
    static void Main()
    {
        // Create products
        var laptop = new Product(1, "Laptop", 800.0);
        var smartphone = new Product(2, "Smartphone", 400.0);

        // Create an inventory manager
        var inventoryManager = new InventoryManager();

        // Add products to the inventory manager
        inventoryManager.AddProduct(laptop);
        inventoryManager.AddProduct(smartphone);

        // Create orders
        var order1 = new Order(101);
        order1.AddProduct(laptop);
        order1.AddProduct(smartphone);

        var order2 = new Order(102);
        order2.AddProduct(smartphone);

        // Add orders to the inventory manager
        inventoryManager.CreateOrder(order1);
        inventoryManager.CreateOrder(order2);

        // Display available products and order history
        inventoryManager.DisplayProducts();
        inventoryManager.DisplayOrders();
    }
}
