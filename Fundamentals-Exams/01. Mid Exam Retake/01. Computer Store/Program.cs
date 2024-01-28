namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double taxRate = 0.2; // Tax rate constant

            double totalPriceWithoutTax = 0;
            double totalPriceWithTax = 0;
            double discount = 0;
            string input;

            // Read prices until the customer type is entered
            while (true)
            {
                input = Console.ReadLine();

                // Check if input is the customer type
                if (input == "special" || input == "regular")
                {
                    break;
                }

                double price;
                // Parse the input as a double and check if it's positive
                if (!double.TryParse(input, out price) || price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                // Calculate total price without tax
                totalPriceWithoutTax += price;
            }

            // Calculate total tax
            double totalTax = totalPriceWithoutTax * taxRate;

            // Calculate total price with tax
            totalPriceWithTax = totalPriceWithoutTax + totalTax;

            // Apply discount if customer is special
            if (input == "special")
            {
                discount = totalPriceWithTax * 0.10; // 10% discount
                totalPriceWithTax -= discount;
            }

            // Check if total price is zero
            if (totalPriceWithTax == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            // Print receipt
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:f2}$");
            Console.WriteLine($"Taxes: {totalTax:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPriceWithTax:f2}$");
        }
    }
}
