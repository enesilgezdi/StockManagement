
namespace StockManagement.ConsoleUI.Models.Dtos
{
    public record ProductDetailDto(
    int Id,
    string categoryName,
    string Name,
    double Price,
    int Stock);
}