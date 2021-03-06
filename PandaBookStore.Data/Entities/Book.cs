﻿using PandaBookStore.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System;

namespace PandaBookStore.Data.Entities
{
    public class Book : BaseEntity
    {
        [StringLength(50, MinimumLength = 1)]
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

        public virtual Category Category { get; set; }

        public int PictureId { get; set; }

        /// <summary>
        /// Gets or sets the stock quantity
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Gets or sets the reserved quantity (ordered but not shipped yet)
        /// </summary>
        public int ReservedQuantity { get; set; }

        public virtual Picture Picture { get; set; }

        //public string GetPictureUrl()
        //{
        //    var pictureBinaryInBase64String = string.Empty;
        //    if (this.Picture != null)
        //    {
        //        pictureBinaryInBase64String = Convert.ToBase64String(this.Picture.PictureBinary, 0, this.Picture.PictureBinary.Length);
        //    }
             
        //    return "data:image/png;base64," + pictureBinaryInBase64String;
        //}

    }
}
