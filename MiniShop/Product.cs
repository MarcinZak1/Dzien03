using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Product
    {
        private int id;
        private String name;
        private double price;
        private String descr = String.Empty;        // = ""
        private UInt16 version = 0;
        private bool promo = false;
        private bool active = true;

        public double Price { get { return price; } }

        // ustawianie parametrow
        public Product(int id, string name, double price, string descr="")          // ostatni parametr jest opcjonalny, bo zawiera wartość domyślną
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.descr = descr;
        }
        // zmiana ceny
        public void ChangePrice(double newPrice)
        {
            // zastanowic się nad mechanizmem logowania historii zmian cen
        }
        // zmiana opisu
        public void ChangeDescription(String newDescr)
        {

        }
        public void SetActive(bool isActive)
        {
            this.active = isActive;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
