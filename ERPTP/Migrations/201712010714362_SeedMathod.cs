namespace ERPTP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMathod : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0465f791-4bd2-47f0-b55a-e6ad541e4be4', N'pikul@domain.com', 0, N'AGBLCHRUD0zktGDNJAqYqXL48j48pCqoNxNHHU5FNYe9URIeA5q+GuT2RfeoP5lJSQ==', N'cc30593f-cb32-426e-ab83-520fc2a5b179', NULL, 0, 0, NULL, 1, 0, N'pikul@domain.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'422db28e-5ff0-4797-923e-99f8c3a83380', N'guest@domain.com', 0, N'AATLnxF2lfJREWpYICCwwNerc96Er3SgJQDTD2UmAu7nSJUzKO+5QkYXCTSCzUowpw==', N'7fcbcf4f-1758-46ec-a5b6-7072569969f6', NULL, 0, 0, NULL, 1, 0, N'guest@domain.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fb8125a1-4b57-48f4-a33d-5ea6a0b63925', N'admin@domain.com', 0, N'ADdT0DVsXK9kk0HXZlV+2CAp1tUgn4cAfmH6UTcrvGiEksBkZi7axFSKaNcKUuGO7w==', N'e9c3e398-3ed0-401d-a76e-4750f481d3a1', NULL, 0, 0, NULL, 1, 0, N'admin@domain.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a7438bc4-2b7c-4e12-b420-340d8f69acba', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fb8125a1-4b57-48f4-a33d-5ea6a0b63925', N'a7438bc4-2b7c-4e12-b420-340d8f69acba')

");
        }
        
        public override void Down()
        {
        }
    }
}
