namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PeopleImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Peoples",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Address = c.String(),
                        Note = c.String(),
                        Image_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PeopleImages", t => t.Image_Id)
                .Index(t => t.Image_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Peoples", "Image_Id", "dbo.PeopleImages");
            DropIndex("dbo.Peoples", new[] { "Image_Id" });
            DropTable("dbo.Peoples");
            DropTable("dbo.PeopleImages");
        }
    }
}
