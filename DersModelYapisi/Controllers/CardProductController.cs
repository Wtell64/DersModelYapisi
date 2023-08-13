using DersModelYapisi.Models;
using DersModelYapisi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
    public class CardProductController : Controller
    {
        public IActionResult Index()
        {
            var product1 = new Product { Id = 1, Name = "Kamera", Price = 510 };
            var product2 = new Product { Id = 2, Name = "Fotoğraf Makinesi", Price = 100 };
            var product3 = new Product { Id = 3, Name = "Telefon", Price = 200 };

            var cartProduct1 = new CardProduct { Product = product1, Quantity = 5, Id = 1, price = 5200 };
            var cartProduct2 = new CardProduct { Product = product2, Quantity = 2, Id = 2, price = 1100 };
            var cartProduct3 = new CardProduct { Product = product3, Quantity = 11, Id = 3, price = 2100 };

            List<CardProduct> cardProducts = new List<CardProduct>();
            cardProducts.Add(cartProduct1);
            cardProducts.Add(cartProduct2);
            cardProducts.Add(cartProduct3);

            CardProductViewModel datas = new CardProductViewModel{  products= cardProducts };

            decimal ToplamTutar = 0;
			decimal ToplamKDV = 0;
			foreach (var cardProduct in datas.products)
            {
                ToplamTutar += cardProduct.price * Convert.ToDecimal(cardProduct.Quantity) * 1.20M;
				ToplamKDV += cardProduct.price * Convert.ToDecimal(cardProduct.Quantity) * 0.20M;
			}

            



            ViewBag.ToplamTutar = ToplamTutar;
            ViewBag.ToplamKDV = ToplamKDV;

            return View(datas);
        }
    }
}
