using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LR9.Models;

namespace LR9.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170425065634_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LR9.Models.DataText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("firstBox")
                        .IsRequired();

                    b.Property<string>("secondBox")
                        .IsRequired();

                    b.Property<string>("thirdBox");

                    b.HasKey("Id");

                    b.ToTable("dataText");
                });
        }
    }
}
