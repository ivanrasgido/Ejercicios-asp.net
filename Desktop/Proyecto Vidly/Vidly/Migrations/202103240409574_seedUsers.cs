namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'54af81f5-2a39-49cd-9085-1a3a173e205d', N'guest@vidly.com', 0, N'ALdUZRF+6qYWIqjww69arUmWJF1KiItxdgKBBnOI5losX15hgwXYTTdKpPNFsQd8WQ==', N'8a2bc352-dccb-4f25-a7f0-e58c261fc01f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b32f4647-ef3b-4b03-b0a0-c930dd05b8bd', N'admin@vidly.com', 0, N'ABzVo8L9LtK6LIDeTfRgUwMinU/b/Fk3r4xMrXCdRKKuPaDUbdpiB5/9RT+qXlQ5yg==', N'c4091ebc-a7d2-4a7c-8b84-2f2cc2bd701b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'afce719c-295c-4327-988f-3aabb8e2316e', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b32f4647-ef3b-4b03-b0a0-c930dd05b8bd', N'afce719c-295c-4327-988f-3aabb8e2316e')

");
        }
        
        public override void Down()
        {
        }
    }
}
