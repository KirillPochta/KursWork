using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    [Table("Purcheshystory")]
    public class PurchaseHistory
    {
        public int _cost, _idOfPurchases, _forPayment,_count;
        public string _nameOfBoughtProduct, _infoOfPurchasesProduct, _loginOfBuyer;
      
        public string LoginOfBuyer
        {
            get
            {
                return _loginOfBuyer;
            }
            set
            {
                _loginOfBuyer = value;
            }
        }
        public string NameOfBoughtProduct
        {
            get
            {
                return _nameOfBoughtProduct;
            }
            set
            {
                _nameOfBoughtProduct = value;
            }
        }
        public string InfoOfPurchasesProduct
        {
            get
            {
                return _infoOfPurchasesProduct;
            }
            set
            {
                _infoOfPurchasesProduct = value;
            }
        }
        public int Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }
        public int IdOfPurchases
        {
            get
            {
                return _idOfPurchases;
            }
            set
            {
                _idOfPurchases = value;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        public int ForPayment
        {
            get
            {
                return _forPayment;
            }
            set
            {
                _forPayment = value;
            }
        }
        public DateTime Dt
        {
            get;set;
        }
        public int Id { get; set; }
        public PurchaseHistory()
        {

        }
        public PurchaseHistory
            (string LoginOfBuyer, string NameOfBoughtProduct,string InfoOfPurchasesProduct, 
            int Cost,int IdOfPurchases,int Count,int ForPayment,DateTime Dt)
        {
            this.LoginOfBuyer = LoginOfBuyer;
            this.NameOfBoughtProduct = NameOfBoughtProduct;
            this.InfoOfPurchasesProduct = InfoOfPurchasesProduct;
            this.Cost = Cost;
            this.IdOfPurchases = IdOfPurchases;
            this.Count = Count;
            this.ForPayment = ForPayment;
            this.Dt = Dt;
        }
    }
}
