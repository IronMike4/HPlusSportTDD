using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HPlusSportTDD.Core
{
  internal class ShoppingCartTests
  {
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void ShouldReturnArticleAddedToCart()
    {
      var item = new AddToCartItem()
      {
        ArticleId = 42,
        Quantity = 5
      };

      var request = new AddToCartRequest()
      {
        Item = item
      };

      var manager = new ShoppingCartManager();

     AddToCartResponse response =  manager.AddToCart(request);

     Assert.IsNotNull(response);
     Assert.Contains(item, response.Items);
    }

  }
}
