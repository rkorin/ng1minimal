namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remimage : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Peoples", "Image_Id", "dbo.PeopleImages");
            DropIndex("dbo.Peoples", new[] { "Image_Id" });
            AddColumn("dbo.Peoples", "ImageId", c => c.Int(nullable: false));
            DropColumn("dbo.Peoples", "Image_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Peoples", "Image_Id", c => c.Int());
            DropColumn("dbo.Peoples", "ImageId");
            CreateIndex("dbo.Peoples", "Image_Id");
            AddForeignKey("dbo.Peoples", "Image_Id", "dbo.PeopleImages", "Id");
        }
    }
}
