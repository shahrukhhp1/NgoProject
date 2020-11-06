﻿// <auto-generated />
using System;
using AspnetIdentityTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspnetIdentityTest.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201106181223_theme_table")]
    partial class theme_table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<long?>("ProvinceId");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.Corporate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Corporates");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.NGO", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactPersonCellNumber");

                    b.Property<string>("ContactPersonEmail");

                    b.Property<string>("ContactPersonName");

                    b.Property<string>("ContactPersonTelephoneNumber");

                    b.Property<string>("ContactPersonTitle");

                    b.Property<string>("Email");

                    b.Property<string>("FBRCertificate");

                    b.Property<string>("Facebook");

                    b.Property<string>("FinancialTransparency");

                    b.Property<string>("FounderName")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("HowToDonate");

                    b.Property<string>("Linkedin");

                    b.Property<string>("Mission");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(250)");

                    b.Property<long>("NumberOfEmployees");

                    b.Property<string>("OfficeAddress");

                    b.Property<string>("PCFPCertificate");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Twitter");

                    b.Property<string>("Website");

                    b.Property<int>("YearFound");

                    b.HasKey("Id");

                    b.ToTable("NGOs");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.NGOCity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CityId");

                    b.Property<long?>("NGOId");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("NGOId");

                    b.ToTable("NGOCitys");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.NGOProvince", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("NGOId");

                    b.Property<long?>("ProvinceId");

                    b.HasKey("Id");

                    b.HasIndex("NGOId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("NGOProvinces");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.NGOTheme", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("NGOId");

                    b.Property<long?>("ThemeId");

                    b.HasKey("Id");

                    b.HasIndex("NGOId");

                    b.HasIndex("ThemeId");

                    b.ToTable("NGOThemes");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.Province", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.Survey", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CorporateId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("IsLocked");

                    b.Property<int>("Month");

                    b.Property<string>("Title");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("CorporateId");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.SurveyAnswer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HTML");

                    b.Property<long?>("NGOId");

                    b.Property<long?>("SurveyQuestionId");

                    b.Property<long?>("SurveyQuestionOptionId");

                    b.HasKey("Id");

                    b.HasIndex("NGOId");

                    b.HasIndex("SurveyQuestionId");

                    b.HasIndex("SurveyQuestionOptionId");

                    b.ToTable("SurveyAnswers");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.SurveyQuestion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("SurveyId");

                    b.Property<string>("Text");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("SurveyQuestions");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.SurveyQuestionOption", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("SurveyQuestionId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("SurveyQuestionId");

                    b.ToTable("SurveyQuestionOptions");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.Theme", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<long?>("CorporateId");

                    b.Property<int>("IntId");

                    b.Property<long?>("NGOId");

                    b.Property<int>("UserType");

                    b.HasIndex("CorporateId");

                    b.HasIndex("NGOId");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.City", b =>
                {
                    b.HasOne("AspnetIdentityTest.Data.Entity.Province", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceId");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.NGOCity", b =>
                {
                    b.HasOne("AspnetIdentityTest.Data.Entity.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("AspnetIdentityTest.Data.Entity.NGO", "NGO")
                        .WithMany("NGOCities")
                        .HasForeignKey("NGOId");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.NGOProvince", b =>
                {
                    b.HasOne("AspnetIdentityTest.Data.Entity.NGO", "NGO")
                        .WithMany("NGOProvinces")
                        .HasForeignKey("NGOId");

                    b.HasOne("AspnetIdentityTest.Data.Entity.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.NGOTheme", b =>
                {
                    b.HasOne("AspnetIdentityTest.Data.Entity.NGO", "NGO")
                        .WithMany("NGOThemes")
                        .HasForeignKey("NGOId");

                    b.HasOne("AspnetIdentityTest.Data.Entity.Theme", "Theme")
                        .WithMany()
                        .HasForeignKey("ThemeId");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.Survey", b =>
                {
                    b.HasOne("AspnetIdentityTest.Data.Entity.Corporate", "Corporate")
                        .WithMany()
                        .HasForeignKey("CorporateId");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.SurveyAnswer", b =>
                {
                    b.HasOne("AspnetIdentityTest.Data.Entity.NGO", "NGO")
                        .WithMany()
                        .HasForeignKey("NGOId");

                    b.HasOne("AspnetIdentityTest.Data.Entity.SurveyQuestion", "SurveyQuestion")
                        .WithMany()
                        .HasForeignKey("SurveyQuestionId");

                    b.HasOne("AspnetIdentityTest.Data.Entity.SurveyQuestionOption", "SurveyQuestionOption")
                        .WithMany()
                        .HasForeignKey("SurveyQuestionOptionId");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.SurveyQuestion", b =>
                {
                    b.HasOne("AspnetIdentityTest.Data.Entity.Survey", "Survey")
                        .WithMany("SurveyQuestions")
                        .HasForeignKey("SurveyId");
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.SurveyQuestionOption", b =>
                {
                    b.HasOne("AspnetIdentityTest.Data.Entity.SurveyQuestion", "SurveyQuestion")
                        .WithMany("SurveyQuestionOptions")
                        .HasForeignKey("SurveyQuestionId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AspnetIdentityTest.Data.Entity.ApplicationUser", b =>
                {
                    b.HasOne("AspnetIdentityTest.Data.Entity.Corporate", "Corporate")
                        .WithMany("Users")
                        .HasForeignKey("CorporateId");

                    b.HasOne("AspnetIdentityTest.Data.Entity.NGO", "NGO")
                        .WithMany("Users")
                        .HasForeignKey("NGOId");
                });
#pragma warning restore 612, 618
        }
    }
}
