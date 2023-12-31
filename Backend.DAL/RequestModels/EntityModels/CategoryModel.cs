﻿using System.ComponentModel.DataAnnotations;
using Backend.DAL.Entities;

namespace Backend.DAL.RequestModels.EntityModels
{
    public class CategoryModel
    {
        [Display(Name = "идентификатор")]
        public Guid Id { get; set; }

        [Display(Name = "Имя категории")]
        [Required(ErrorMessage = "Укажите имя категории ")]
        [MaxLength(60)]
        public string Name { get; set; }

        public List<Product>? Products { get; set; } = new();
    }
}
