namespace MovieRater.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        ContentId = c.Int(nullable: false, identity: true),
                        RunTime = c.Double(nullable: false),
                        AuthorId = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        MaturityRating = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ContentId);
            
            CreateTable(
                "dbo.Show",
                c => new
                    {
                        ContentId = c.Int(nullable: false, identity: true),
                        SeasonCount = c.Int(nullable: false),
                        AuthorId = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        MaturityRating = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ContentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Show");
            DropTable("dbo.Movie");
        }
    }
}
