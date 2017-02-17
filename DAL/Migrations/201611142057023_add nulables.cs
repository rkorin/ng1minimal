namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnulables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Peoples", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Peoples", "ImageId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Peoples", "ImageId", c => c.Int(nullable: false));
            AlterColumn("dbo.Peoples", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
