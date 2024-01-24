﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using tetris_api;

#nullable disable

namespace tetris_api.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20230810054009_UseGuid")]
    partial class UseGuid
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityAlwaysColumns(modelBuilder);

            modelBuilder.Entity("tetris_api.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<int>("PlayerScore")
                        .HasColumnType("integer")
                        .HasColumnName("player_score");

                    b.Property<Guid>("ScoreId")
                        .HasColumnType("uuid")
                        .HasColumnName("score_id");

                    b.Property<int>("ThisUserId")
                        .HasColumnType("integer")
                        .HasColumnName("this_user_id");

                    b.HasKey("Id")
                        .HasName("pk_scores");

                    b.HasIndex("ThisUserId")
                        .HasDatabaseName("ix_scores_this_user_id");

                    b.ToTable("scores", (string)null);
                });

            modelBuilder.Entity("tetris_api.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("HashedPassword")
                        .HasColumnType("text")
                        .HasColumnName("hashed_password");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<string>("Username")
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("tetris_api.Score", b =>
                {
                    b.HasOne("tetris_api.User", "User")
                        .WithMany()
                        .HasForeignKey("ThisUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_scores_users_this_user_id");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
