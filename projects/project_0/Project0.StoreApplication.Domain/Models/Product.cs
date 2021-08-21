using System;

namespace Project0.StoreApplication.Domain.Models
{
  public class Products
  {
    public string Name { get; set; }

    public override string ToString()
    {
      return Name ?? DateTime.Now.ToLongDateString();
    }
  }
}