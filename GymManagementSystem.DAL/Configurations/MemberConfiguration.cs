using GymManagementSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystem.DAL.Configurations
{
    internal class MemberConfiguration:GymUserConfiguration<Member>,IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x=>x.CreatedAt).HasColumnName("HireDate").HasDefaultValueSql("GetDate()");
            base.Configure(builder);
        }
    }
}
