using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelManager
{
    public class Category
    {
        /// <summary>
        /// Id категории
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Доступность категории для пользователя
        /// </summary>
        public bool IsAvailable { get; set; }
    }
}
