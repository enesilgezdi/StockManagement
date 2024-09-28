
namespace StockManagement.ConsoleUI.Models.Dtos
{
    public record ProductDetailDto(
    Guid Id,
    string categoryName,
    string Name,
    double Price,
    int Stock);
}