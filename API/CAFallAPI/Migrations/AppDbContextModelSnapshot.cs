using CAFallAPI;
using global::Microsoft.EntityFrameworkCore;
using global::Microsoft.EntityFrameworkCore.Infrastructure;

namespace global::CAFallAPI.Migrations
{
    [global::Microsoft.EntityFrameworkCore.Infrastructure.DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : global::Microsoft.EntityFrameworkCore.Infrastructure.ModelSnapshot
    {
        protected override void BuildModel(global::Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            global::Microsoft.EntityFrameworkCore.NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CAFallAPI.Models.Customer", b =>
                {
                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("integer");

                    global::Microsoft.EntityFrameworkCore.NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("text");

                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("text");

                    b.HasKey("Id");

                    global::Microsoft.EntityFrameworkCore.RelationalEntityTypeBuilderExtensions.ToTable("Customers");
                });

            modelBuilder.Entity("CAFallAPI.Models.Employee", b =>
                {
                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("integer");

                    global::Microsoft.EntityFrameworkCore.NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("text");

                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("text");

                    b.HasKey("Id");

                    global::Microsoft.EntityFrameworkCore.RelationalEntityTypeBuilderExtensions.ToTable("Employees");
                });

            modelBuilder.Entity("CAFallAPI.Models.Order", b =>
                {
                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("integer");

                    global::Microsoft.EntityFrameworkCore.NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    global::Microsoft.EntityFrameworkCore.RelationalEntityTypeBuilderExtensions.ToTable("Orders");
                });

            modelBuilder.Entity("CAFallAPI.Models.Product", b =>
                {
                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("integer");

                    global::Microsoft.EntityFrameworkCore.NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("boolean");

                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("text");

                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("integer");

                    global::Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    global::Microsoft.EntityFrameworkCore.RelationalEntityTypeBuilderExtensions.ToTable("Products");
                });

            modelBuilder.Entity("CAFallAPI.Models.Order", b =>
                {
                    b.HasOne("CAFallAPI.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(global::Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CAFallAPI.Models.Product", b =>
                {
                    b.HasOne("CAFallAPI.Models.Order", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("CAFallAPI.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CAFallAPI.Models.Order", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
