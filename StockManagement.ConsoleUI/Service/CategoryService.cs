

using StockManagement.ConsoleUI.Data;
using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Service;

public class CategoryService
{
    CategoryData categoryData = new CategoryData();

    public void GetAll()
    {
        List<Category> categories = categoryData.CategoriesAll();

        foreach(Category category in categories)
        {
            Console.WriteLine(category);
        }
    }

    public void GetById(int id)
    {
        Category? category = categoryData.GetById(id);

        if (category == null)
        {

            Console.WriteLine($"Aradıgınız Id ye göre ürün bulunmadı : {id}");
            return;
        }

        Console.WriteLine(category);


    }

    public Category Add(Category category)
    {
        Category category1 = categoryData.Add(category);

        Console.WriteLine($"Added category: {category1}"); 

        return category1;
    }


}
