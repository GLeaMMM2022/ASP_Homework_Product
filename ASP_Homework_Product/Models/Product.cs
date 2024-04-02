﻿using System;
namespace ASP_Homework_Product.Models
{
    public class Product
    {
        private static int instanceCounter = 0;

        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string Description { get; }
        public string ImagePath { get; }

        public Product(string name, decimal cost, string description, string imagePath)
        {
            Id = instanceCounter;
            Name = name;
            Cost = cost;
            Description = description;

            instanceCounter++;
            ImagePath = imagePath;
        }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}";
        }
    }
}

