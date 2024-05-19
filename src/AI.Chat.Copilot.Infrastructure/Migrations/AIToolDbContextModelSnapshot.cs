﻿// <auto-generated />
using System;
using AI.Chat.Copilot.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AI.Chat.Copilot.Infrastructure.Migrations
{
    [DbContext(typeof(AIToolDbContext))]
    partial class AIToolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AI.Chat.Copilot.Domain.Models.AIApps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AIModelType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MaxTokens")
                        .HasColumnType("integer");

                    b.Property<string>("ModelId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Prompt")
                        .IsUnicode(true)
                        .HasColumnType("text");

                    b.Property<string>("ProxyHost")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Secret")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Temperature")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("AIApps");
                });

            modelBuilder.Entity("AI.Chat.Copilot.Domain.Models.AppChat", b =>
                {
                    b.Property<string>("Id")
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("timestamp");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AppChats");
                });

            modelBuilder.Entity("AI.Chat.Copilot.Domain.Models.AppChatMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ChatId")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AppChatMessage");
                });
#pragma warning restore 612, 618
        }
    }
}
