namespace GroupBuying.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Store = c.Int(nullable: false),
                        Branch = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Group_Id = c.Int(),
                        Item_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .ForeignKey("dbo.Items", t => t.Item_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Group_Id)
                .Index(t => t.Item_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        CategoryId_Id = c.Int(),
                        Item_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId_Id)
                .ForeignKey("dbo.Items", t => t.Item_Id)
                .Index(t => t.CategoryId_Id)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Mail = c.String(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        CreditNumber = c.String(nullable: false),
                        CreditExpiration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Groups", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Items", "Item_Id", "dbo.Items");
            DropForeignKey("dbo.Items", "CategoryId_Id", "dbo.Categories");
            DropForeignKey("dbo.Groups", "Group_Id", "dbo.Groups");
            DropIndex("dbo.Items", new[] { "Item_Id" });
            DropIndex("dbo.Items", new[] { "CategoryId_Id" });
            DropIndex("dbo.Groups", new[] { "User_Id" });
            DropIndex("dbo.Groups", new[] { "Item_Id" });
            DropIndex("dbo.Groups", new[] { "Group_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Items");
            DropTable("dbo.Groups");
            DropTable("dbo.Categories");
        }
    }
}
