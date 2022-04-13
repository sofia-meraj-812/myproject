namespace WebApplication10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        sch = c.String(),
                        docid = c.Int(nullable: false),
                        timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Doctors", t => t.docid, cascadeDelete: true)
                .Index(t => t.docid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "docid", "dbo.Doctors");
            DropIndex("dbo.Schedules", new[] { "docid" });
            DropTable("dbo.Schedules");
        }
    }
}
