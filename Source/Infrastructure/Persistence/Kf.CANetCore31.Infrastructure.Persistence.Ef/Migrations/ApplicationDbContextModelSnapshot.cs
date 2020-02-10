﻿// <auto-generated />
using Kf.CANetCore31.Infrastructure.Persistence.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kf.CANetCore31.Core.Domain.People.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("BIGINT")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Kf.CANetCore31.Core.Domain.People.Person", b =>
                {
                    b.OwnsOne("Kf.CANetCore31.Core.Domain.People.Name", "Name", b1 =>
                        {
                            b1.Property<long>("PersonId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("BIGINT")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("FirstName")
                                .HasColumnName("firstName")
                                .HasColumnType("nvarchar(150)")
                                .HasMaxLength(150);

                            b1.Property<string>("LastName")
                                .HasColumnName("lastName")
                                .HasColumnType("nvarchar(150)")
                                .HasMaxLength(150);

                            b1.HasKey("PersonId");

                            b1.ToTable("People");

                            b1.WithOwner()
                                .HasForeignKey("PersonId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
