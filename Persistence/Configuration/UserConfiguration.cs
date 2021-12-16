using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Constant;
using Share.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // SQL config

            builder.ToTable("User");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.IsAdmin).HasDefaultValue(false);


            //Seed Data

            builder.HasData(SeedDatabase());

        }


        public Collection<User> SeedDatabase()
        {
            var usuarios = new Collection<User>();
            var imagen = "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526";
            usuarios.Add(
            new User { Id = 3, Created = DateTime.Now, Name = "admin", Password = "admin123", Email = "admin@admin", IsAdmin = true, ImgProfile = imagen });

            return usuarios;
        }
    }
}
