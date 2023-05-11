﻿// <auto-generated />
using System;
using Demo_EFCF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo_EFCF.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demo_EFCF.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("clubs");
                });

            modelBuilder.Entity("Demo_EFCF.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("players");
                });

            modelBuilder.Entity("Demo_EFCF.Models.PlayerInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("playerInfomations");
                });

            modelBuilder.Entity("Demo_EFCF.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("positions");
                });

            modelBuilder.Entity("PlayerPosition", b =>
                {
                    b.Property<int>("PlayersId")
                        .HasColumnType("int");

                    b.Property<int>("PositionsId")
                        .HasColumnType("int");

                    b.HasKey("PlayersId", "PositionsId");

                    b.HasIndex("PositionsId");

                    b.ToTable("PlayerPosition");
                });

            modelBuilder.Entity("Demo_EFCF.Models.Player", b =>
                {
                    b.HasOne("Demo_EFCF.Models.Club", null)
                        .WithMany("Players")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("Demo_EFCF.Models.PlayerInformation", b =>
                {
                    b.HasOne("Demo_EFCF.Models.Player", "Player")
                        .WithOne("PlayerInformation")
                        .HasForeignKey("Demo_EFCF.Models.PlayerInformation", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("PlayerPosition", b =>
                {
                    b.HasOne("Demo_EFCF.Models.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo_EFCF.Models.Position", null)
                        .WithMany()
                        .HasForeignKey("PositionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Demo_EFCF.Models.Club", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("Demo_EFCF.Models.Player", b =>
                {
                    b.Navigation("PlayerInformation")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
