﻿// <auto-generated />
using System;
using AdmissionSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdmissionSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdmissionSystem.Model.Accabtable_config", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Accepted_Or_Not")
                        .HasColumnType("bit");

                    b.Property<string>("Accepted_wish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FK_Statues_of_admission_eligibiltyid")
                        .HasColumnType("int");

                    b.Property<int>("FK_studentId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("FK_Statues_of_admission_eligibiltyid");

                    b.HasIndex("FK_studentId")
                        .IsUnique();

                    b.ToTable("Accabtable_config");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Admission_Eligibilty_Certificate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FK_Type_of_high_school_Cirtificateid")
                        .HasColumnType("int");

                    b.Property<int>("FK_student_InfoId")
                        .HasColumnType("int");

                    b.Property<string>("Image_of_crtificat_URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LAnguge_of_the_addmintion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subscription_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("The_Rate")
                        .HasColumnType("int");

                    b.Property<string>("check_recipt_image_URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city_of_high_school_cirtificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("course_number")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_of_high_school_cirtificate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("wish1id")
                        .HasColumnType("int");

                    b.Property<int?>("wish2id")
                        .HasColumnType("int");

                    b.Property<int?>("wish3id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("FK_Type_of_high_school_Cirtificateid");

                    b.HasIndex("FK_student_InfoId")
                        .IsUnique();

                    b.HasIndex("wish1id");

                    b.HasIndex("wish2id");

                    b.HasIndex("wish3id");

                    b.ToTable("Admission_Eligibilty_Certificate");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Broken_Relationshib_Stat_Dep_Chair", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Chair_count")
                        .HasColumnType("int");

                    b.Property<int?>("FK_statues_Of_Admission_Eligibiltyid")
                        .HasColumnType("int");

                    b.Property<int?>("Fk_departmentid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("FK_statues_Of_Admission_Eligibiltyid");

                    b.HasIndex("Fk_departmentid");

                    b.ToTable("Broken_Relationshib_Stat_Dep_Chair");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("country_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FK_facultyid")
                        .HasColumnType("int");

                    b.Property<string>("specialization_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("FK_facultyid");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Department_relation_Type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FK_Departmentid")
                        .HasColumnType("int");

                    b.Property<int?>("FK_type_Of_High_School_Cirtificateid")
                        .HasColumnType("int");

                    b.Property<double>("Minemum_of_Rate")
                        .HasColumnType("float");

                    b.Property<double>("Rate_of_chaire_count")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("FK_Departmentid");

                    b.HasIndex("FK_type_Of_High_School_Cirtificateid");

                    b.ToTable("Department_relation_Type");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nick_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone_Number")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Faculty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Faculty_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Identity_classes.MyIdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Identity_classes.MyIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Persentage_count_for_each__country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FK_countryId")
                        .HasColumnType("int");

                    b.Property<int?>("FK_statues_of_admission_eligibiltyid")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("FK_countryId")
                        .IsUnique();

                    b.HasIndex("FK_statues_of_admission_eligibiltyid");

                    b.ToTable("Persentage_count_for_each__country");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Statues_Of_Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Checked_Identity")
                        .HasColumnType("bit");

                    b.Property<bool>("Checked_Rate")
                        .HasColumnType("bit");

                    b.Property<bool>("Checked_city_certificate")
                        .HasColumnType("bit");

                    b.Property<bool>("Checked_recipet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date_of_Acshiving")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FK_Employee_Infoid")
                        .HasColumnType("int");

                    b.Property<int>("FK_Student_InfoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("FK_Employee_Infoid");

                    b.HasIndex("FK_Student_InfoId")
                        .IsUnique();

                    b.ToTable("Statues_Of_Student");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Statues_of_admission_eligibilty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Begaining_date_of_the_process")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type_of_admission_eligibilty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("semester_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("semester_no")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Statues_of_admission_eligibilty");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Cirtificate_cityid")
                        .HasColumnType("int");

                    b.Property<string>("Civil_Registriation_City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Civil_Registrition_No")
                        .HasColumnType("int");

                    b.Property<string>("Current_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Father_Name_AR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Father_Name_EN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name_AR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name_EN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Full_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grandfather_Name_AR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grandfather_Name_EN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Home_s_Phone")
                        .HasColumnType("int");

                    b.Property<int>("Identity_No")
                        .HasColumnType("int");

                    b.Property<string>("Identity_back_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identity_front_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marital_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mobile_Phone")
                        .HasColumnType("int");

                    b.Property<string>("Mother_Name_AR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mother_Name_EN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nick_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Passport_No")
                        .HasColumnType("int");

                    b.Property<int?>("Statues_Of_Admission_Eligibiltyid")
                        .HasColumnType("int");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("high_school_certificate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cirtificate_cityid");

                    b.HasIndex("Statues_Of_Admission_Eligibiltyid");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Tracking_Rate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FK_Employee_Infoid")
                        .HasColumnType("int");

                    b.Property<int>("FK_Student_InfoId")
                        .HasColumnType("int");

                    b.Property<int>("new_rate")
                        .HasColumnType("int");

                    b.Property<int>("old_rate")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("FK_Employee_Infoid");

                    b.HasIndex("FK_Student_InfoId")
                        .IsUnique();

                    b.ToTable("Tracking_Rate");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Type_of_high_school_Cirtificate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Type_of_high_school_Cirtificate");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Accabtable_config", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Statues_of_admission_eligibilty", "FK_Statues_of_admission_eligibilty")
                        .WithMany()
                        .HasForeignKey("FK_Statues_of_admission_eligibiltyid");

                    b.HasOne("AdmissionSystem.Model.Student", "FK_student")
                        .WithOne("FK_Accabtable_configInfo")
                        .HasForeignKey("AdmissionSystem.Model.Accabtable_config", "FK_studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdmissionSystem.Model.Admission_Eligibilty_Certificate", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Type_of_high_school_Cirtificate", "FK_Type_of_high_school_Cirtificate")
                        .WithMany()
                        .HasForeignKey("FK_Type_of_high_school_Cirtificateid");

                    b.HasOne("AdmissionSystem.Model.Student", "FK_student_Info")
                        .WithOne("Admission_Eligibilty_Requist_For_UNsy_Certificate")
                        .HasForeignKey("AdmissionSystem.Model.Admission_Eligibilty_Certificate", "FK_student_InfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdmissionSystem.Model.Department_relation_Type", "wish1")
                        .WithMany()
                        .HasForeignKey("wish1id");

                    b.HasOne("AdmissionSystem.Model.Department_relation_Type", "wish2")
                        .WithMany()
                        .HasForeignKey("wish2id");

                    b.HasOne("AdmissionSystem.Model.Department_relation_Type", "wish3")
                        .WithMany()
                        .HasForeignKey("wish3id");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Broken_Relationshib_Stat_Dep_Chair", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Statues_of_admission_eligibilty", "FK_statues_Of_Admission_Eligibilty")
                        .WithMany()
                        .HasForeignKey("FK_statues_Of_Admission_Eligibiltyid");

                    b.HasOne("AdmissionSystem.Model.Department", "Fk_department")
                        .WithMany()
                        .HasForeignKey("Fk_departmentid");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Department", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Faculty", "FK_faculty")
                        .WithMany()
                        .HasForeignKey("FK_facultyid");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Department_relation_Type", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Department", "FK_Department")
                        .WithMany()
                        .HasForeignKey("FK_Departmentid");

                    b.HasOne("AdmissionSystem.Model.Type_of_high_school_Cirtificate", "FK_type_Of_High_School_Cirtificate")
                        .WithMany()
                        .HasForeignKey("FK_type_Of_High_School_Cirtificateid");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Persentage_count_for_each__country", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Country", "FK_country")
                        .WithOne("FK_persentage_count_for_each__country")
                        .HasForeignKey("AdmissionSystem.Model.Persentage_count_for_each__country", "FK_countryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdmissionSystem.Model.Statues_of_admission_eligibilty", "FK_statues_of_admission_eligibilty")
                        .WithMany()
                        .HasForeignKey("FK_statues_of_admission_eligibiltyid");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Statues_Of_Student", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Employee", "FK_Employee_Info")
                        .WithMany()
                        .HasForeignKey("FK_Employee_Infoid");

                    b.HasOne("AdmissionSystem.Model.Student", "FK_Student_Info")
                        .WithOne("Statues_Of_Student")
                        .HasForeignKey("AdmissionSystem.Model.Statues_Of_Student", "FK_Student_InfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdmissionSystem.Model.Student", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Country", "Cirtificate_city")
                        .WithMany()
                        .HasForeignKey("Cirtificate_cityid");

                    b.HasOne("AdmissionSystem.Model.Statues_of_admission_eligibilty", "Statues_Of_Admission_Eligibilty")
                        .WithMany()
                        .HasForeignKey("Statues_Of_Admission_Eligibiltyid");
                });

            modelBuilder.Entity("AdmissionSystem.Model.Tracking_Rate", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Employee", "FK_Employee_Info")
                        .WithMany()
                        .HasForeignKey("FK_Employee_Infoid");

                    b.HasOne("AdmissionSystem.Model.Student", "FK_Student_Info")
                        .WithOne("Tracking_Rate")
                        .HasForeignKey("AdmissionSystem.Model.Tracking_Rate", "FK_Student_InfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Identity_classes.MyIdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Identity_classes.MyIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Identity_classes.MyIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Identity_classes.MyIdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdmissionSystem.Model.Identity_classes.MyIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AdmissionSystem.Model.Identity_classes.MyIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
