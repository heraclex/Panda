using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PandaBookStore.Service.Models
{
    public class BookModel :BaseModel
    {
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string AuthorName { get; set; }

        public string Publisher { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Range(0, 5)]
        public int Rate { get; set; }

        public int CategoryId { get; set; }

        public int PictureId { get; set; }

        /// <summary>
        /// Gets or sets the stock quantity
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Gets or sets the reserved quantity (ordered but not shipped yet)
        /// </summary>
        public int ReservedQuantity { get; set; }
    }
}
