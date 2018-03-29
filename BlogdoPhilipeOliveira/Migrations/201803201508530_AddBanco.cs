namespace BlogdoPhilipeOliveira.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 500),
                        DateAdded = c.DateTime(nullable: false),
                        Dateupdated = c.DateTime(nullable: false),
                        postingBody = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.posts");
        }
    }
}
