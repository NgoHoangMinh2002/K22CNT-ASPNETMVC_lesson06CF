namespace NhmLesson06CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhmBooks",
                c => new
                    {
                        NhmID = c.Int(nullable: false, identity: true),
                        NhmBookId = c.String(),
                        NhmTitle = c.String(),
                        NhmAuthor = c.String(),
                        NhmYear = c.Int(nullable: false),
                        NhmPulisher = c.String(),
                        NhmPicture = c.String(),
                        NhmCategoryId = c.Int(nullable: false),
                        NhmCategory_NhmId = c.Int(),
                    })
                .PrimaryKey(t => t.NhmID)
                .ForeignKey("dbo.NhmCategories", t => t.NhmCategory_NhmId)
                .Index(t => t.NhmCategory_NhmId);
            
            CreateTable(
                "dbo.NhmCategories",
                c => new
                    {
                        NhmId = c.Int(nullable: false, identity: true),
                        NhmCategoryName = c.String(),
                    })
                .PrimaryKey(t => t.NhmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhmBooks", "NhmCategory_NhmId", "dbo.NhmCategories");
            DropIndex("dbo.NhmBooks", new[] { "NhmCategory_NhmId" });
            DropTable("dbo.NhmCategories");
            DropTable("dbo.NhmBooks");
        }
    }
}
