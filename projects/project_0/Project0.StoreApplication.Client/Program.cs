using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client
{
  class Program
  {
    static void Main(string[] args)
    {

      var p = new Program();

      p.PrintAllStoreLocations();


      System.Console.WriteLine(p.SelectAStore());
      // p.SelectAStore();
      // 

      //p.SelectAproduct();
      p.PrintProductList();
      System.Console.WriteLine(p.SelectAproduct());
      //p.SelectAproduct();
    }

    void PrintAllStoreLocations()
    {
      var storeRepository = new StoreRepository();
      int i = 1;

      foreach (var store in storeRepository.Stores)
      {
        System.Console.WriteLine(i + " - " + store);
        i += 1;
      }
      // Print product list 


    }

    Store SelectAStore()
    {
      var sr = new StoreRepository().Stores;

      Console.WriteLine("Select a Store: ");

      var option = int.Parse(Console.ReadLine());
      var store = sr[option - 1];

      return store;
    }
    // Print product List
    void PrintProductList()
    {
      var productRepository = new ProductRepository();
      int i = 1;

      foreach (var product in productRepository.Product)
      {
        System.Console.WriteLine(i + " - " + product);
        i += 1;
      }
    }
    // Let customer choose their products
    Products SelectAproduct()
    {
      var pdt = new ProductRepository().Product;
      Console.WriteLine("Select a product: ");

      var option = int.Parse(Console.ReadLine());
      var product = pdt[option - 1];
      return product;


    }
  }
}

