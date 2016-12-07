using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AjaxDemo.Models;

namespace AjaxDemo.Migrations
{
    [DbContext(typeof(AjaxDemoContext))]
    [Migration("20161205215706_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
