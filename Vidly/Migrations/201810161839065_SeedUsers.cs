namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'65d4f548-650f-4818-866d-38593309adc3', N'admin@vidly.com', 0, N'ALbfNXB0Ga2hYK0uWjqEotDxV/b4qHOZASN+a7SmRpKE/q/0XFPEXnfjvgARAsKN2g==', N'cbb4a1d7-bbce-4ff3-ac58-c25be558f59c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c04a0702-183e-43c0-b46d-48ac3638df36', N'guest@vidly.com', 0, N'AKvu1bikEDjdvwNvxGUqVl/my9jbbtYsaivVrCiweD05PSVvq8Wo65UUXa+KQpTOrQ==', N'5a9b67b0-574f-424d-8e67-ca267aef004e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'27f65860-49cb-4a26-9ae7-97dd121c0f5f', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'65d4f548-650f-4818-866d-38593309adc3', N'27f65860-49cb-4a26-9ae7-97dd121c0f5f')

");
        }
        
        public override void Down()
        {
        }
    }
}
