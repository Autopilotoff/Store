using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Store.Domain.Entities;
using System.Web.Mvc;

namespace Store.WebUI.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private const string sessionKey = "Cart";
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            // получить объект Cart из сеанса
            Cart cart = (Cart)controllerContext.HttpContext.Session[sessionKey];
            // создать экземпляр Cart, если его не обнаружено в даных сеанса
            if (cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session[sessionKey] = cart;
            }
            // вернуть объект cart
            return cart;
        }
    }
}