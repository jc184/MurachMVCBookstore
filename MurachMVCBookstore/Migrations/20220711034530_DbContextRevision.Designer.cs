﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MurachMVCBookstore.Models;

namespace MurachMVCBookstore.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    [Migration("20220711034530_DbContextRevision")]
    partial class DbContextRevision
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MurachMVCBookstore.Models.DomainModels.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "Michelle",
                            LastName = "Alexander"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "Stephen E.",
                            LastName = "Ambrose"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "Margaret",
                            LastName = "Atwood"
                        },
                        new
                        {
                            AuthorId = 4,
                            FirstName = "Jane",
                            LastName = "Austen"
                        },
                        new
                        {
                            AuthorId = 5,
                            FirstName = "James",
                            LastName = "Baldwin"
                        },
                        new
                        {
                            AuthorId = 6,
                            FirstName = "Emily",
                            LastName = "Bronte"
                        },
                        new
                        {
                            AuthorId = 7,
                            FirstName = "Agatha",
                            LastName = "Christie"
                        },
                        new
                        {
                            AuthorId = 8,
                            FirstName = "Ta-Nehisi",
                            LastName = "Coates"
                        },
                        new
                        {
                            AuthorId = 9,
                            FirstName = "Jared",
                            LastName = "Diamond"
                        },
                        new
                        {
                            AuthorId = 10,
                            FirstName = "Joan",
                            LastName = "Didion"
                        },
                        new
                        {
                            AuthorId = 11,
                            FirstName = "Daphne",
                            LastName = "Du Maurier"
                        },
                        new
                        {
                            AuthorId = 12,
                            FirstName = "Tina",
                            LastName = "Fey"
                        },
                        new
                        {
                            AuthorId = 13,
                            FirstName = "Roxane",
                            LastName = "Gay"
                        },
                        new
                        {
                            AuthorId = 14,
                            FirstName = "Dashiel",
                            LastName = "Hammett"
                        },
                        new
                        {
                            AuthorId = 15,
                            FirstName = "Frank",
                            LastName = "Herbert"
                        },
                        new
                        {
                            AuthorId = 16,
                            FirstName = "Aldous",
                            LastName = "Huxley"
                        },
                        new
                        {
                            AuthorId = 17,
                            FirstName = "Stieg",
                            LastName = "Larsson"
                        },
                        new
                        {
                            AuthorId = 18,
                            FirstName = "David",
                            LastName = "McCullough"
                        },
                        new
                        {
                            AuthorId = 19,
                            FirstName = "Toni",
                            LastName = "Morrison"
                        },
                        new
                        {
                            AuthorId = 20,
                            FirstName = "George",
                            LastName = "Orwell"
                        },
                        new
                        {
                            AuthorId = 21,
                            FirstName = "Mary",
                            LastName = "Shelley"
                        },
                        new
                        {
                            AuthorId = 22,
                            FirstName = "Sun",
                            LastName = "Tzu"
                        },
                        new
                        {
                            AuthorId = 23,
                            FirstName = "Augusten",
                            LastName = "Burroughs"
                        },
                        new
                        {
                            AuthorId = 25,
                            FirstName = "JK",
                            LastName = "Rowling"
                        },
                        new
                        {
                            AuthorId = 26,
                            FirstName = "Seth",
                            LastName = "Grahame-Smith"
                        });
                });

            modelBuilder.Entity("MurachMVCBookstore.Models.DomainModels.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            GenreId = "history",
                            Price = 18.0,
                            Title = "1776"
                        },
                        new
                        {
                            BookId = 2,
                            GenreId = "scifi",
                            Price = 5.5,
                            Title = "1984"
                        },
                        new
                        {
                            BookId = 3,
                            GenreId = "mystery",
                            Price = 4.5,
                            Title = "And Then There Were None"
                        },
                        new
                        {
                            BookId = 4,
                            GenreId = "history",
                            Price = 11.5,
                            Title = "Band of Brothers"
                        },
                        new
                        {
                            BookId = 5,
                            GenreId = "novel",
                            Price = 10.99,
                            Title = "Beloved"
                        },
                        new
                        {
                            BookId = 6,
                            GenreId = "memoir",
                            Price = 13.5,
                            Title = "Between the World and Me"
                        },
                        new
                        {
                            BookId = 7,
                            GenreId = "memoir",
                            Price = 4.25,
                            Title = "Bossypants"
                        },
                        new
                        {
                            BookId = 8,
                            GenreId = "scifi",
                            Price = 16.25,
                            Title = "Brave New World"
                        },
                        new
                        {
                            BookId = 9,
                            GenreId = "history",
                            Price = 15.0,
                            Title = "D-Day"
                        },
                        new
                        {
                            BookId = 10,
                            GenreId = "memoir",
                            Price = 12.5,
                            Title = "Down and Out in Paris and London"
                        },
                        new
                        {
                            BookId = 11,
                            GenreId = "scifi",
                            Price = 8.75,
                            Title = "Dune"
                        },
                        new
                        {
                            BookId = 12,
                            GenreId = "novel",
                            Price = 9.0,
                            Title = "Emma"
                        },
                        new
                        {
                            BookId = 13,
                            GenreId = "scifi",
                            Price = 6.5,
                            Title = "Frankenstein"
                        },
                        new
                        {
                            BookId = 14,
                            GenreId = "novel",
                            Price = 10.25,
                            Title = "Go Tell it on the Mountain"
                        },
                        new
                        {
                            BookId = 15,
                            GenreId = "history",
                            Price = 15.5,
                            Title = "Guns, Germs, and Steel"
                        },
                        new
                        {
                            BookId = 16,
                            GenreId = "memoir",
                            Price = 14.5,
                            Title = "Hunger"
                        },
                        new
                        {
                            BookId = 17,
                            GenreId = "mystery",
                            Price = 6.75,
                            Title = "Murder on the Orient Express"
                        },
                        new
                        {
                            BookId = 18,
                            GenreId = "novel",
                            Price = 8.5,
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            BookId = 19,
                            GenreId = "mystery",
                            Price = 10.99,
                            Title = "Rebecca"
                        },
                        new
                        {
                            BookId = 20,
                            GenreId = "history",
                            Price = 5.75,
                            Title = "The Art of War"
                        },
                        new
                        {
                            BookId = 21,
                            GenreId = "mystery",
                            Price = 8.5,
                            Title = "The Girl with the Dragon Tattoo"
                        },
                        new
                        {
                            BookId = 22,
                            GenreId = "scifi",
                            Price = 12.5,
                            Title = "The Handmaid's Tale"
                        },
                        new
                        {
                            BookId = 23,
                            GenreId = "mystery",
                            Price = 10.99,
                            Title = "The Maltese Falcon"
                        },
                        new
                        {
                            BookId = 24,
                            GenreId = "history",
                            Price = 13.75,
                            Title = "The New Jim Crow"
                        },
                        new
                        {
                            BookId = 25,
                            GenreId = "memoir",
                            Price = 13.5,
                            Title = "The Year of Magical Thinking"
                        },
                        new
                        {
                            BookId = 26,
                            GenreId = "novel",
                            Price = 9.0,
                            Title = "Wuthering Heights"
                        },
                        new
                        {
                            BookId = 27,
                            GenreId = "memoir",
                            Price = 11.0,
                            Title = "Running With Scissors"
                        },
                        new
                        {
                            BookId = 28,
                            GenreId = "novel",
                            Price = 8.75,
                            Title = "Pride and Prejudice and Zombies"
                        },
                        new
                        {
                            BookId = 29,
                            GenreId = "novel",
                            Price = 9.75,
                            Title = "Harry Potter and the Sorcerer's Stone"
                        });
                });

            modelBuilder.Entity("MurachMVCBookstore.Models.DomainModels.BookAuthor", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthors");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 18
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 20
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 7
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 2
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 19
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 8
                        },
                        new
                        {
                            BookId = 7,
                            AuthorId = 12
                        },
                        new
                        {
                            BookId = 8,
                            AuthorId = 16
                        },
                        new
                        {
                            BookId = 9,
                            AuthorId = 2
                        },
                        new
                        {
                            BookId = 10,
                            AuthorId = 20
                        },
                        new
                        {
                            BookId = 11,
                            AuthorId = 15
                        },
                        new
                        {
                            BookId = 12,
                            AuthorId = 4
                        },
                        new
                        {
                            BookId = 13,
                            AuthorId = 21
                        },
                        new
                        {
                            BookId = 14,
                            AuthorId = 5
                        },
                        new
                        {
                            BookId = 15,
                            AuthorId = 9
                        },
                        new
                        {
                            BookId = 16,
                            AuthorId = 13
                        },
                        new
                        {
                            BookId = 17,
                            AuthorId = 7
                        },
                        new
                        {
                            BookId = 18,
                            AuthorId = 4
                        },
                        new
                        {
                            BookId = 19,
                            AuthorId = 11
                        },
                        new
                        {
                            BookId = 20,
                            AuthorId = 22
                        },
                        new
                        {
                            BookId = 21,
                            AuthorId = 17
                        },
                        new
                        {
                            BookId = 22,
                            AuthorId = 3
                        },
                        new
                        {
                            BookId = 23,
                            AuthorId = 14
                        },
                        new
                        {
                            BookId = 24,
                            AuthorId = 1
                        },
                        new
                        {
                            BookId = 25,
                            AuthorId = 10
                        },
                        new
                        {
                            BookId = 26,
                            AuthorId = 6
                        },
                        new
                        {
                            BookId = 27,
                            AuthorId = 23
                        },
                        new
                        {
                            BookId = 28,
                            AuthorId = 4
                        },
                        new
                        {
                            BookId = 28,
                            AuthorId = 26
                        },
                        new
                        {
                            BookId = 29,
                            AuthorId = 25
                        });
                });

            modelBuilder.Entity("MurachMVCBookstore.Models.DomainModels.Genre", b =>
                {
                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = "novel",
                            Name = "Novel"
                        },
                        new
                        {
                            GenreId = "memoir",
                            Name = "Memoir"
                        },
                        new
                        {
                            GenreId = "mystery",
                            Name = "Mystery"
                        },
                        new
                        {
                            GenreId = "scifi",
                            Name = "Science Fiction"
                        },
                        new
                        {
                            GenreId = "history",
                            Name = "History"
                        });
                });

            modelBuilder.Entity("MurachMVCBookstore.Models.DomainModels.Book", b =>
                {
                    b.HasOne("MurachMVCBookstore.Models.DomainModels.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MurachMVCBookstore.Models.DomainModels.BookAuthor", b =>
                {
                    b.HasOne("MurachMVCBookstore.Models.DomainModels.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MurachMVCBookstore.Models.DomainModels.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
