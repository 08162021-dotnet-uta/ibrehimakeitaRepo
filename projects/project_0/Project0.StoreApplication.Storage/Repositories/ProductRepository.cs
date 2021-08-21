using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
namespace Project0.StoreApplication.Storage.Repositories
{
  public class ProductRepository
  {
    public List<Products> Product { get; set; }

    public ProductRepository()
    {
      Product = new List<Products>()
      {

       new Products(){ Name = "Java" },
        new Products(){ Name = "Angular" },
        new Products(){ Name = "React" }
      };
    }
  }

}


