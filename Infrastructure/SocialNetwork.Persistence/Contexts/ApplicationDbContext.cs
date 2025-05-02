using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventAboutInformation> EventAboutInformations { get; set; }
    public DbSet<NotificationPreferences> NotificationPreferences { get; set; }
    public DbSet<NotificationSettings> NotificationSettings { get; set; }
    public DbSet<PrivacySettings> PrivacySettings { get; set; }
    public DbSet<UserProfile> UsersProfiles { get; set; }
    public DbSet<UserProfileDescription> UserProfileDescriptions { get; set; }
    public DbSet<UserProfileSocialLink> UserProfileSocialLinks { get; set; }
    public DbSet<PostComment> PostComments { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}