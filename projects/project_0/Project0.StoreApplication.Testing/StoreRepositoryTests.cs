using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing
{
  public class StoreRepositoryTests
  {
    [Fact]
    public void Tes_StoreCollection()
    {
      // arrange = instance of the entity to test
      var sut = new StoreRepository();
      // act = excecute sut for data
      var actual = sut.Stores;
      //assert
      Assert.NotNull(actual);

    }

  }
}