﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SocialMediaApp.Infrastructure.Data;

#nullable disable

namespace SocialMediaApp.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConnectionProfile", b =>
                {
                    b.Property<Guid>("ProfileID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserConnectionID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfileID", "UserConnectionID");

                    b.HasIndex("UserConnectionID");

                    b.ToTable("ConnectionProfiles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Comment", b =>
                {
                    b.Property<Guid>("CommentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsUpdated")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ParentCommentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProfileID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("TotalComment")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalLikes")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalRetweet")
                        .HasColumnType("bigint");

                    b.Property<Guid>("TweetID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CommentID");

                    b.HasIndex("ParentCommentID");

                    b.HasIndex("ProfileID");

                    b.HasIndex("TweetID");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.CommentFiles", b =>
                {
                    b.Property<Guid>("CommentFileID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CommentFileID");

                    b.HasIndex("CommentID");

                    b.ToTable("CommentFiles");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Genre", b =>
                {
                    b.Property<Guid>("GenreID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Like", b =>
                {
                    b.Property<Guid>("LikeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CommentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ProfileID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TweetID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LikeID");

                    b.HasIndex("CommentID");

                    b.HasIndex("ProfileID");

                    b.HasIndex("TweetID");

                    b.ToTable("Likes", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Notification", b =>
                {
                    b.Property<Guid>("NotificationID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProfileID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("NotificationID");

                    b.HasIndex("ProfileID");

                    b.ToTable("Notifications", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Profile", b =>
                {
                    b.Property<Guid>("ProfileID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("ProfileBackgroundURL")
                        .IsRequired()
                        .HasColumnType("VARCHAR(max)");

                    b.Property<string>("ProfileImgURL")
                        .IsRequired()
                        .HasColumnType("VARCHAR(max)");

                    b.Property<long>("TotalFollowers")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalFollowing")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalTweets")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfileID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Profiles", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Retweet", b =>
                {
                    b.Property<Guid>("RetweetID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProfileID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TweetID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("RetweetID");

                    b.HasIndex("CommentID");

                    b.HasIndex("ProfileID");

                    b.HasIndex("TweetID");

                    b.ToTable("Retweets", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Tweet", b =>
                {
                    b.Property<Guid>("TweetID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GenreID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsUpdated")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProfileID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("TotalComments")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalLikes")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalRetweets")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("TweetID");

                    b.HasIndex("GenreID");

                    b.HasIndex("ProfileID");

                    b.ToTable("Tweets", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.TweetFiles", b =>
                {
                    b.Property<Guid>("TweetFilesID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TweetID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TweetFilesID");

                    b.HasIndex("TweetID");

                    b.ToTable("TweetFiles", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.UserConnections", b =>
                {
                    b.Property<Guid>("UserConnectionID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FollowedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FollowerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserConnectionID");

                    b.ToTable("UserConnections", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProfileID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ConnectionProfile", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Profile", null)
                        .WithMany("ConnectionProfiles")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SocialMediaApp.Core.Domain.Entites.UserConnections", null)
                        .WithMany("ConnectionProfiles")
                        .HasForeignKey("UserConnectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Comment", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Comment", "ParentComment")
                        .WithMany("Replies")
                        .HasForeignKey("ParentCommentID")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Profile", "Profile")
                        .WithMany("Comments")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Tweet", "Tweet")
                        .WithMany("Comments")
                        .HasForeignKey("TweetID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ParentComment");

                    b.Navigation("Profile");

                    b.Navigation("Tweet");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.CommentFiles", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Comment", "Comment")
                        .WithMany("Files")
                        .HasForeignKey("CommentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Like", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Comment", "Comment")
                        .WithMany("Likes")
                        .HasForeignKey("CommentID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Profile", "Profile")
                        .WithMany("Likes")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Tweet", "Tweet")
                        .WithMany("Likes")
                        .HasForeignKey("TweetID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Comment");

                    b.Navigation("Profile");

                    b.Navigation("Tweet");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Notification", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Profile", "Profile")
                        .WithMany("Notifications")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Profile", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationUser", "User")
                        .WithOne("Profile")
                        .HasForeignKey("SocialMediaApp.Core.Domain.Entites.Profile", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Retweet", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Comment", "Comment")
                        .WithMany("Retweets")
                        .HasForeignKey("CommentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Profile", "Profile")
                        .WithMany("Retweets")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Tweet", "Tweet")
                        .WithMany("Retweets")
                        .HasForeignKey("TweetID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Profile");

                    b.Navigation("Tweet");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Tweet", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Genre", "Genre")
                        .WithMany("Tweets")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Profile", "Profile")
                        .WithMany("Tweets")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.TweetFiles", b =>
                {
                    b.HasOne("SocialMediaApp.Core.Domain.Entites.Tweet", "Tweet")
                        .WithMany("Files")
                        .HasForeignKey("TweetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tweet");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationUser", b =>
                {
                    b.OwnsMany("SocialMediaApp.Core.DTO.AuthenticationDTO.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<Guid>("ApplicationUserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<DateTime>("CreatedOn")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("ExpiredOn")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime?>("RevokedOn")
                                .HasColumnType("datetime2");

                            b1.Property<string>("Token")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ApplicationUserId", "Id");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner()
                                .HasForeignKey("ApplicationUserId");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Comment", b =>
                {
                    b.Navigation("Files");

                    b.Navigation("Likes");

                    b.Navigation("Replies");

                    b.Navigation("Retweets");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Genre", b =>
                {
                    b.Navigation("Tweets");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Profile", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ConnectionProfiles");

                    b.Navigation("Likes");

                    b.Navigation("Notifications");

                    b.Navigation("Retweets");

                    b.Navigation("Tweets");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.Tweet", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Files");

                    b.Navigation("Likes");

                    b.Navigation("Retweets");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.Entites.UserConnections", b =>
                {
                    b.Navigation("ConnectionProfiles");
                });

            modelBuilder.Entity("SocialMediaApp.Core.Domain.IdentityEntites.ApplicationUser", b =>
                {
                    b.Navigation("Profile")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
