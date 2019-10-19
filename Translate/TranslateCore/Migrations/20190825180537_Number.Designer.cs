﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TranslateCore.Domain;

namespace TranslateCore.Migrations
{
    [DbContext(typeof(TranslateDb))]
    [Migration("20190825180537_Number")]
    partial class Number
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TranslateCore.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorEng");

                    b.Property<string>("ColorRu");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("TranslateCore.Models.IrregularVerb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Infinitive")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PastParticiple")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PastSimple")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("TranslateRu")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("IrregularVerbs");
                });

            modelBuilder.Entity("TranslateCore.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("TranslateCore.Models.Number", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Word");

                    b.Property<string>("WordRu");

                    b.HasKey("Id");

                    b.ToTable("Numbers");
                });

            modelBuilder.Entity("TranslateCore.Models.Pronoun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PronounEng");

                    b.Property<string>("PronounRu");

                    b.HasKey("Id");

                    b.ToTable("Pronouns");
                });

            modelBuilder.Entity("TranslateCore.Models.Verb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VerbEng");

                    b.Property<string>("VerbRu");

                    b.HasKey("Id");

                    b.ToTable("Verbs");
                });

            modelBuilder.Entity("TranslateCore.Models.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WordEng");

                    b.Property<string>("WordRu");

                    b.HasKey("Id");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("TranslateCore.Models.WordType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("NameRu");

                    b.HasKey("Id");

                    b.ToTable("WordTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
