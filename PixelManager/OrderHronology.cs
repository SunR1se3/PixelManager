using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelManager
{
    public class OrderHronology
    {
        /// <summary>
        /// Id хронологии заказа
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        public DateTime DateCreationOrder { get; set; }

        /// <summary>
        /// Дата принятия заказа
        /// </summary>
        public DateTime DateAcceptionOrder { get; set; }

        /// <summary>
        /// Изготовление заказа
        /// </summary>
        public bool Production { get; set; }

        /// <summary>
        /// Заказ готов
        /// </summary>
        public bool isDone { get; set; }

        /// <summary>
        /// id заказа
        /// </summary>
        public Guid IdOrder { get; set; }
    }
}
