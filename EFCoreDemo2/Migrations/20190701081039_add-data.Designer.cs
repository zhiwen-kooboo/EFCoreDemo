﻿// <auto-generated />
using EFCoreDemo2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreDemo2.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20190701081039_add-data")]
    partial class adddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("EFCoreDemo.Model.Converter.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Name = "233",
                            Type = "Science"
                        },
                        new
                        {
                            Id = 6,
                            Name = "测试匿名类",
                            Type = "Classic"
                        });
                });

            modelBuilder.Entity("EFCoreDemo2.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MailFrom");

                    b.Property<string>("MailTo");

                    b.Property<string>("Test");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("EFCoreDemo2.Models.Order", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EFCoreDemo2.Models.OrderAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BillingAddress");

                    b.Property<string>("ShippingAddress");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EFCoreDemo2.Models.Email", b =>
                {
                    b.OwnsOne("EFCoreDemo2.Models.EmailContent", "EmailContent", b1 =>
                        {
                            b1.Property<int>("EmailId");

                            b1.Property<string>("Content");

                            b1.Property<string>("Title");

                            b1.HasKey("EmailId");

                            b1.ToTable("Emails");

                            b1.HasOne("EFCoreDemo2.Models.Email")
                                .WithOne("EmailContent")
                                .HasForeignKey("EFCoreDemo2.Models.EmailContent", "EmailId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("EFCoreDemo2.Models.Order", b =>
                {
                    b.HasOne("EFCoreDemo2.Models.OrderAddress", "OrderAddress")
                        .WithOne()
                        .HasForeignKey("EFCoreDemo2.Models.Order", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
