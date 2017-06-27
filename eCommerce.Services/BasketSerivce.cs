using eCommerce.Contracts.Repositories;
using eCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace eCommerce.Services
{
    public class BasketSerivce
    {

        IRepositoryBase<Basket> baskets;
        public const string BasketSessionName = "eCommerceBasket";

        public BasketSerivce(IRepositoryBase<Basket> baskets)
        {
            this.baskets = baskets;
        }


        private Basket createNewBasket(HttpContextBase httpContext)
        {

            // new cookie
            HttpCookie cookie = new HttpCookie(BasketSessionName);

            Basket basket = new Basket();
            basket.date = DateTime.Now; // add the time
            basket.BasketId = Guid.NewGuid();

            // update database

            baskets.Insert(basket);
            baskets.Commit();

            
            cookie.Value = basket.BasketId.ToString();
            cookie.Expires = DateTime.Now.AddDays(1);
            httpContext.Response.Cookies.Add(cookie);

            return basket;
        }


        public Basket GetBasket(HttpContextBase httpContext)
        {


            HttpCookie cookie = httpContext.Request.Cookies.Get(BasketSessionName);
            Basket basket;

            Guid basketId;


            if (cookie != null)
            {


                if (Guid.TryParse(cookie.Value,out basketId))
                {
                    basket = baskets.GetById(basketId);
                    if (basket == null)
                    {
                        basket = createNewBasket(httpContext);
                    }
                    
                }
                else
                {
                    basket = createNewBasket(httpContext);
                }

            }
            else
            {
                basket = createNewBasket(httpContext);
            }

            return basket;

        }


        public bool AddToBasket(HttpContextBase httpContext, int productId, int quantity)
        {

            bool success = true;

            Basket basket = GetBasket(httpContext);
            BasketItem item = basket.BasketItems.FirstOrDefault(i => i.ProductId == productId);

            if (item==null)
            {
                item = new BasketItem()
                {
                    BasketId = basket.BasketId,
                    ProductId=productId,
                    Quantity=quantity
                };
                basket.BasketItems.Add(item);
            }
            else
            {
                item.Quantity = item.Quantity + 1;
            }

            baskets.Commit();

            return success;


        }


    }
}
