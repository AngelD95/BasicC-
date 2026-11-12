using CsBases.Fundamentals;

class Program
{
	static void Main()
	{
		var laptop = new Product("Laptop", 1500);
		WriteLine(laptop.GetDescription());

		var soporte = new ServiceProduct("Soporte Técnico", 300, 30);
		WriteLine(soporte.GetDescription());
		
		var product = new Product("Mouse Gamer", 75);
		var productDto = ProductAdapter.ToDto(product);
		WriteLine($"Producto: {productDto.Name}, Precio: {productDto.Price}, Código: {productDto.Code}");

		// Inyección de dependencias
		ILabelService labelService = new LabelService();
		var manager = new ProductManager(labelService);
		var monitor = new Product("monitor Msi", 350);
		var instalation = new ServiceProduct("Instalación de monitor", 20, 30);
		manager.PrintLabel(monitor);
		manager.PrintLabel(instalation);
	}
}