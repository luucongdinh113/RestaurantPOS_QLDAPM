﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantPOS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantPOS.Data.Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("FOOD");
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Name).HasMaxLength(200).IsUnicode().IsRequired();
            builder.Property(f => f.UnitPrice).IsRequired();
            builder.Property(f => f.Category).IsRequired();
            builder.Property(f => f.Description).IsUnicode().HasDefaultValue("None.");
            builder.Property(f => f.ImageURL).IsRequired();
        }
    }
}
