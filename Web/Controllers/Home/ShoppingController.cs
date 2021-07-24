using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Web.Models;
using Web.ViewModel;

namespace Web.Controllers.Home
{
    public class ShoppingController : Controller
    {
        SneakerEntities db = new SneakerEntities();
        
        //HIỂN THỊ DANH SÁCH CÁC ĐƠN HÀNG
        public ActionResult Index()
        {
            return View(db.DATHANGs);
        }

         #region ShoppingCart
       
        public ActionResult ShowCart()
        {
            return View();
        }
        public ActionResult AddToCart(int id)
        {
            var _Product = db.SANPHAMs.Find(id);
            var CartList = new List<CartVM>();
            if (Session["Cart"] != null)
            {
                CartList = (List<CartVM>)Session["Cart"];
                var OldCart = CartList.Find(m => m.Product.ID_SANPHAM ==id);
                if (OldCart != null)
                {
                    var NewCart = new CartVM { Product = _Product, Soluong = OldCart.Soluong + 1 };
                    CartList.Remove(OldCart);
                    CartList.Add(NewCart);
                }
                else
                {
                    CartList.Add(new CartVM { Product = _Product, Soluong = 1 });
                }
            }
            else
            {
                CartList.Add(new CartVM { Product = _Product, Soluong = 1 });
            }
            Session["Cart"] = CartList;
            return RedirectToAction("ShowCart");
        }
   
        public ActionResult RemoveCart(int id)
        {
            var CartList = (List<CartVM>)Session["Cart"];
            var _Cart = CartList.SingleOrDefault(m => m.Product.ID_SANPHAM == id);
            CartList.Remove(_Cart);
            Session["Cart"] = CartList;
            return new EmptyResult();
        }
        #endregion

        #region Create Order
        public ActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckOut([Bind(Exclude = "ID_DATHANG")]DATHANG model)
        {
            var CartList = (List<CartVM>)Session["Cart"];
            var OrdetailsList = new List<CT_DATHANG>();
            CartList.ForEach(m =>
            {
                var _Product = db.SANPHAMs.Find(m.Product.ID_SANPHAM);
                OrdetailsList.Add(new CT_DATHANG
                {
                    ID_SANPHAM = _Product.ID_SANPHAM,
                    SOLUONG = m.Soluong
                });
            });
            model.ISACTIVE = false;
            // thêm danh sách OrderDetails
            model.CT_DATHANG = OrdetailsList;
            // Thêm bảng Order
            db.DATHANGs.Add(model);
            db.SaveChanges();
            Session["Cart"] = null;
            return RedirectToAction("CheckOutSuccess");
        }
        public ActionResult CheckOutSuccess()
        {
            return View();
        }
        #endregion

        #region Details Order
        public ActionResult Details(int id)
        {
            return View(db.DATHANGs.Find(id));
        }
        #endregion

        #region Delete Order
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var _Order = db.DATHANGs.Find(id);
            _Order.CT_DATHANG.ToList().ForEach(m => db.CT_DATHANG.Remove(m));
            db.DATHANGs.Remove(_Order);
            db.SaveChanges();
            return new EmptyResult();
        }
        #endregion
    }

   
}
