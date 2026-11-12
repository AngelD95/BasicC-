using CsBases.Fundamentals;

public class ProductRepository
{
	public async Task<Product> GetProduct(int id)
	{
		// obtenerde un BD o llamada a una api
		// externa o podria ser de un
		// archivo json, xml, etc...
		WriteLine("Buscando producto...");
		await Task.Delay(2000);
		return new Product("Producto Simulado", 500);
	}
}