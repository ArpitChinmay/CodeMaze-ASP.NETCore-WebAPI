﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData
                (
                    new Company
                    {
                        Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                        Name = "Infosys India Ltd.",
                        Address = "TP1/1 Mahindra World City",
                        Country = "India"
                    },
                    new Company
                    {
                        Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                        Name = "Renault Nissan India Ltd.",
                        Address = "TP1/2 Mahindra World City",
                        Country = "India"
                    }
                ) ;
        }
    }
}
