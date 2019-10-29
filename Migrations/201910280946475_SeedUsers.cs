namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b7f95a32-5ab3-4501-8663-ae3bc70f379f', N'guest@vidly.com', 0, N'AD9r9aNAah93rhBAzgdIcw2vLxK7yrUyIMnmgZCaJBXaZt+hBGnDgn/jwCyIba+47Q==', N'92028761-2756-42c1-8b2c-148967a9a05f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ee3a275e-3689-455c-badc-cc7a8b64cb8c', N'admin@vidly.com', 0, N'AAT26bPZJe5t9Z4ny5v4yQHNX/towigWb8Bc18QIJ7ctMpkO3rhtM/v8PNU3UspXRw==', N'543a22ae-1fa7-411d-b769-dbfd1cb6f7c1', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6c1f61de-a4c2-4318-8287-528c9735a58e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ee3a275e-3689-455c-badc-cc7a8b64cb8c', N'6c1f61de-a4c2-4318-8287-528c9735a58e')
");
        }
        
        public override void Down()
        {
        }
    }
}
