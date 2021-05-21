using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    [Table("Products")]
    public class Products
    {

        public int _cost,_count;
        private string _nameOfProduct, _info,_whoAddProduct;
        [Key]
        public string NameOfProduct
        {
            get
            {
                return _nameOfProduct;
            }
            set
            {
                _nameOfProduct = value;
            }
        }
        public string WhoAddProduct
        {
            get
            {
                return _whoAddProduct;
            }
            set
            {
                _whoAddProduct = value;
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
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                _info = value;
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
        public Products()
        {

        }
        public Products(string NameOfProduct, string Info, int Cost,string WhoAddProduct)
        {
            this.NameOfProduct = NameOfProduct;
            this.Info = Info;
            this.Cost = Cost;
            this.WhoAddProduct = WhoAddProduct;
        }
    }

    
}
