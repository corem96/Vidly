namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'027f2a5c-e0a5-4755-b6c2-b9166e3fa16c', N'admin@vidly.com', 0, N'AITZOkOi/IRxnlLO3H3gjzPZAJ1AtfYa13evtnJpxSgpGjf5a2LHjxZNnZwc5UfV7w==', N'c773cdab-ff56-421c-9492-1a9297703f82', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c1ab4bf1-13ef-4d78-9d31-85a9aa455988', N'guest@email.com', 0, N'ALzaT1p3LpqYYVkKpFKGjSHVIQYxz6w0lIn/NllzTWxs2s7h/y0f0e9HM35bG4DpKQ==', N'cd112521-1575-48df-b23d-47d928d51f3d', NULL, 0, 0, NULL, 1, 0, N'guest@email.com')
                
                INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'66d54318-cb79-4f5e-84fb-c82a7e88cce2', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'027f2a5c-e0a5-4755-b6c2-b9166e3fa16c', N'66d54318-cb79-4f5e-84fb-c82a7e88cce2')
            ");
        }

        public override void Down()
        {
        }
    }
}
