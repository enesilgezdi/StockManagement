
using StockManagement.ConsoleUI.Data;
using StockManagement.ConsoleUI.Models;
using StockManagement.ConsoleUI.Models.Dtos;


namespace StockManagement.ConsoleUI.Service;

public class ProductService
{
    ProductData productData = new ProductData();

    public void GetAll()
    {
        List<Product> products = productData.GetAll();

        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }

    public void GetById(int id) {
        Product? product = productData.GetById(id);

        if (product == null) {

            Console.WriteLine($"Aradıgınız Id ye göre ürün bulunmadı : {id}");
            return;
        }

        Console.WriteLine(product);
    }

    public void TotalProductPriceSum()
    {
        double total = productData.TotalProductPriceSum();
        Console.WriteLine($"Ürünlerin fiyat toplamı : {total}");
    }

    public void GetAllPriceRange(double min, double max)
    {
        List<Product> filteredData = productData.GetAllPriceRange(min, max);

        foreach (Product product in filteredData) {
            Console.WriteLine(product);
        }
    }
    public void GetAllProductNameContains(string text)
    {
        List<Product> filtered = productData.GetAllProductNameContains(text);

        foreach (Product product in filtered)
        {
            Console.WriteLine(filtered);
        }
    }

    public void Delete(int id)
    {
        Product? product = productData.Delete(id);

        if (product == null) {
            Console.WriteLine($"Ürün bulunamadı : Id = {id}");
            return;
        
        }
        Console.WriteLine("Ürün silindi");
        Console.WriteLine(product);
    }

    public void GetAllProductsByStockRange(int min, int max)
    {
        List<Product> products = productData.GeGetAllProductsByStockRange(min, max);
        products.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllProductsOrderByDescendingName()
    {
        List<Product> filtered = productData.GetAllProductsOrderByDescendingName();
        filtered.ForEach(x => Console.WriteLine(x));
    }

    public void GetAllProductsOrderByAscendingName()
    {
        List <Product> filtered = productData.GetAllProductsOrderByAscendingName();
        filtered.ForEach(x => Console.WriteLine(x));


    }

    public void GetExpensiveProduct()
    {
        Product product = productData.GetExpensiveProduct();
        Console.WriteLine($"En pahalı Ürün : {product}");
    }

    public void GetCheapProduct()
    {
        Product product = productData.GetCheapProduct();
        Console.WriteLine($"En Ucuz Ürün: {product}");
    }

    public void GetDetails()
    {
        List<ProductDetailDto> details = productData.GetDetails();
        details.ForEach(x => Console.WriteLine(x));
    }

    public void GetDetailsV2()
    {
        List<Category> categories = categoryService.GetAllCategories();
        List<ProductDetailDto> details = productData.GetDetailsV2(categories);
        details.ForEach(x => Console.WriteLine(x));
    }

    public void GetDetailById(int id)
    {
        List<Category> categories = categoryService.GetAllCategories();

        ProductDetailDto? detail = productData.GetDetailById(id, categories);
        if (detail is null)
        {
            Console.WriteLine($"Ürün Bulunamadı : Id= {id}");
            return;
        }

        Console.WriteLine(detail);
    }
}
