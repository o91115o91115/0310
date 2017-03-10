using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{

    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void InsertOrder()
        {

        }
        /// <summary>
        /// 刪除訂單By id
        /// </summary>
        public void DeleteOrderByid()
        {
        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdataOrder()
        {
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id">訂單id</param>
        /// <returns></returns>
        public Models.Class1 GetOrderByid(string id)
        {
            Models.Class1 result = new Class1();
            result.CustomerID = "123";
            result.ShipCity = "taiwan";
            return result;
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Class1> GetOrders()
        {
            return new List<Class1>();
        }
    }
}