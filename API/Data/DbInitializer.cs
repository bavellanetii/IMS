using System.Text.Json;
using API.Entities;

namespace API.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(WarehouseContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Grades.Any())
                {
                    var gradesData = File.ReadAllText("../API/Data/SeedData/Grades.json");
                    var grades = JsonSerializer.Deserialize<List<Grade>>(gradesData);
                    foreach (var item in grades)
                    {
                        context.Grades.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

                if (!context.LotNumbers.Any())
                {
                    var lotNumbersData = File.ReadAllText("../API/Data/SeedData/LotNumbers.json");
                    var lotNumbers = JsonSerializer.Deserialize<List<LotNumber>>(lotNumbersData);
                    foreach (var item in lotNumbers)
                    {
                        context.LotNumbers.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

                if (!context.Packaging.Any())
                {
                    var packagingData = File.ReadAllText("../API/Data/SeedData/Packaging.json");
                    var packaging = JsonSerializer.Deserialize<List<Packaging>>(packagingData);
                    foreach (var item in packaging)
                    {
                        context.Packaging.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

                if (!context.Statuses.Any())
                {
                    var statusesData = File.ReadAllText("../API/Data/SeedData/Statuses.json");
                    var statuses = JsonSerializer.Deserialize<List<Status>>(statusesData);
                    foreach (var item in statuses)
                    {
                        context.Statuses.Add(item);
                    }
                    await context.SaveChangesAsync();
                }


                if (!context.Warehouses.Any())
                {
                    var warehousesData = File.ReadAllText("../API/Data/SeedData/Warehouses.json");
                    var warehouses = JsonSerializer.Deserialize<List<Warehouse>>(warehousesData);
                    foreach (var item in warehouses)
                    {
                        context.Warehouses.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

                
                if (!context.Products.Any())
                {
                    var productsData = File.ReadAllText("../API/Data/SeedData/Stock.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                    foreach (var item in products)
                    {
                        context.Products.Add(item);
                    }
                    await context.SaveChangesAsync();
                }
            }

            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<DbInitializer>();
                logger.LogError(ex.Message);
            }
        }
    }
}