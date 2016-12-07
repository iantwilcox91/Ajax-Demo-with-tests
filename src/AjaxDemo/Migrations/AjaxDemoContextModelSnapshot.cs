using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AjaxDemo.Models;

namespace AjaxDemo.Migrations
{
    [DbContext(typeof(AjaxDemoContext))]
    partial class AjaxDemoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AjaxDemo.Models.Destination", b =>
                {
                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("Id");

                    b.HasKey("City");

                    b.ToTable("Destinations");
                });
        }
    }
}
