// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShopWebAPIs.Models.DBContext;

namespace OnlineShopWebAPIs.Migrations
{
    [DbContext(typeof(OnlineShopDbContext))]
    [Migration("20221014160608_productImagesTableIsAdded")]
    partial class productImagesTableIsAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineShopWebAPIs.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("categoryName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("categoryId");

                    b.ToTable("Tb_Categories");
                });

            modelBuilder.Entity("OnlineShopWebAPIs.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<string>("defaultImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("productName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("salesPrice")
                        .HasColumnType("float");

                    b.HasKey("productId");

                    b.HasIndex("categoryId");

                    b.ToTable("Tb_Products");
                });

            modelBuilder.Entity("OnlineShopWebAPIs.Models.ProductImage", b =>
                {
                    b.Property<int>("productImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<string>("productImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productImageId");

                    b.HasIndex("productId");

                    b.ToTable("Tb_ProductImages");
                });

            modelBuilder.Entity("OnlineShopWebAPIs.Models.Review", b =>
                {
                    b.Property<int>("reviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<string>("reviewDescription")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("reviewId");

                    b.HasIndex("productId");

                    b.ToTable("Tb_Reviews");
                });

            modelBuilder.Entity("OnlineShopWebAPIs.Models.Product", b =>
                {
                    b.HasOne("OnlineShopWebAPIs.Models.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("OnlineShopWebAPIs.Models.ProductImage", b =>
                {
                    b.HasOne("OnlineShopWebAPIs.Models.Product", "product")
                        .WithMany("productImages")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("OnlineShopWebAPIs.Models.Review", b =>
                {
                    b.HasOne("OnlineShopWebAPIs.Models.Product", "product")
                        .WithMany("reviews")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("OnlineShopWebAPIs.Models.Category", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("OnlineShopWebAPIs.Models.Product", b =>
                {
                    b.Navigation("productImages");

                    b.Navigation("reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
