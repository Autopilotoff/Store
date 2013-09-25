using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Store.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Введите Ваше имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Заполните первую строку адреса(улица, дом)")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Введите название Вашего города")]
        public string City { get; set; }

        [Required(ErrorMessage = "Введите название Вашей области(штата)")]
        public string State { get; set; }

        public string Zip { get; set; }

        [Required(ErrorMessage = "Введите название Вашей страны")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
