﻿// <auto-generated />
using System;
using InventoryAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryAPI.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20250405104948_mks1234")]
    partial class mks1234
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InventoryAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("InventoryAPI.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("InventoryAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ColorCode")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InventoryAPI.Models.PurchaseInvoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("PurchaseInvoices");
                });

            modelBuilder.Entity("InventoryAPI.Models.PurchaseInvoiceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseInvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaseInvoiceId");

                    b.ToTable("PurchaseInvoiceItems");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockInVoucher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext");

                    b.Property<string>("OperatingOrder")
                        .HasColumnType("longtext");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransferDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("WarehouseKeeperName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("StockInVouchers");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockInVoucherItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ColorCode")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StockInVoucherId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StockInVoucherId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("StockInVoucherItems");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockOutVoucher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext");

                    b.Property<string>("OperatingOrder")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("TransferDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("WarehouseKeeperName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("StockOutVouchers");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockOutVoucherItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ColorCode")
                        .HasColumnType("longtext");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StockOutVoucherId")
                        .HasColumnType("int");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StockOutVoucherId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("StockOutVoucherItems");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockTransfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FromWarehouseId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext");

                    b.Property<string>("OperatingOrder")
                        .HasColumnType("longtext");

                    b.Property<int>("ToWarehouseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransferDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("WarehouseKeeperName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("StockTransfers");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockTransferItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ColorCode")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StockTransferId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StockTransferId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("StockTransferItems");
                });

            modelBuilder.Entity("InventoryAPI.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("InventoryAPI.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("InventoryAPI.Models.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("InventoryAPI.Models.WarehouseStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WarehouseStocks");
                });

            modelBuilder.Entity("InventoryAPI.Models.Product", b =>
                {
                    b.HasOne("InventoryAPI.Models.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("InventoryAPI.Models.PurchaseInvoice", b =>
                {
                    b.HasOne("InventoryAPI.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("InventoryAPI.Models.PurchaseInvoiceItem", b =>
                {
                    b.HasOne("InventoryAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.PurchaseInvoice", "PurchaseInvoice")
                        .WithMany("Items")
                        .HasForeignKey("PurchaseInvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("PurchaseInvoice");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockInVoucher", b =>
                {
                    b.HasOne("InventoryAPI.Models.Supplier", null)
                        .WithMany("StockInVouchers")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockInVoucherItem", b =>
                {
                    b.HasOne("InventoryAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.StockInVoucher", "StockInVoucher")
                        .WithMany("Items")
                        .HasForeignKey("StockInVoucherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("StockInVoucher");

                    b.Navigation("Supplier");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockOutVoucher", b =>
                {
                    b.HasOne("InventoryAPI.Models.Customer", "Customer")
                        .WithMany("StockOutVouchers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockOutVoucherItem", b =>
                {
                    b.HasOne("InventoryAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.StockOutVoucher", "StockOutVoucher")
                        .WithMany("Items")
                        .HasForeignKey("StockOutVoucherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("StockOutVoucher");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockTransferItem", b =>
                {
                    b.HasOne("InventoryAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.StockTransfer", "StockTransfer")
                        .WithMany("Items")
                        .HasForeignKey("StockTransferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.Warehouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("StockTransfer");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("InventoryAPI.Models.SubCategory", b =>
                {
                    b.HasOne("InventoryAPI.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("InventoryAPI.Models.WarehouseStock", b =>
                {
                    b.HasOne("InventoryAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryAPI.Models.Warehouse", "Warehouse")
                        .WithMany("Stocks")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("InventoryAPI.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("InventoryAPI.Models.Customer", b =>
                {
                    b.Navigation("StockOutVouchers");
                });

            modelBuilder.Entity("InventoryAPI.Models.PurchaseInvoice", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockInVoucher", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockOutVoucher", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("InventoryAPI.Models.StockTransfer", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("InventoryAPI.Models.Supplier", b =>
                {
                    b.Navigation("StockInVouchers");
                });

            modelBuilder.Entity("InventoryAPI.Models.Warehouse", b =>
                {
                    b.Navigation("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
