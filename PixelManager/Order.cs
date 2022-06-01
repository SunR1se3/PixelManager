using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelManager
{
    public class Order
    {
        /// <summary>
        /// Id заказа
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Фио клиента
        /// </summary>
        public string Fio { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Почта
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Товар
        /// </summary>
        public string WareName { get; set; }

        /// <summary>
        /// Подробности заказа
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Исходники, отправленные клиентом
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// id товара
        /// </summary>
        public Guid WareId { get; set; }
    }
}
