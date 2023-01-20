using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW6
{
    internal class Shop
    {
        private string _name;
        private string _adress;
        private string _discription;
        private string _phone;
        private string _email;
        private double _area;

        public Shop(string name)
        {
            _name = name;
        }

        public void ChangeName(string name)
        {
            _name = name;
        }

        public void SetAdress(string adr)
        {
            _adress = adr;
        }

        public void SetDiscription(string discr)
        {
            _discription = discr;
        }

        public void SetPhone(string ph)
        {
            _phone = ph;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }


        public void ShowShopInfo()
        {
            Console.WriteLine($"Информация о магазине {_name}");
            Console.WriteLine($"Магазин расположен по адресу {_adress}");
            Console.WriteLine($"Для связи с руководством используйте телефон {_phone} " +
                $"или email {_email}");
            Console.WriteLine($"Описание магазина: {_discription}");
        }

        //task 2
        public void SetArea(double area)
        {
            _area = area;
        }

        public void ShowArea()
        {
            Console.WriteLine($"The area of the shop {_name} is {_area}");
        }

        public static Shop operator +(Shop sh, double a)
        {
            sh._area += a;
            return sh;
        }

        public static Shop operator -(Shop sh, double a)
        {
            sh._area -= a;
            return sh;
        }

        public static bool operator ==(Shop sh1, Shop sh2)
        {
            return sh1._area == sh2._area;
        }

        public static bool operator !=(Shop sh1, Shop sh2)
        {
            return !(sh1._area == sh2._area);
        }

        public static bool operator <(Shop sh1, Shop sh2)
        {
            return (sh1._area < sh2._area);
        }

        public static bool operator >(Shop sh1, Shop sh2)
        {
            return (sh1._area > sh2._area);
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Shop)) return false;
            return this == (Shop)obj;
        }



    }
}
