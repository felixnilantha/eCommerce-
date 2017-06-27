namespace eCommerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestMigs",
                c => new
                    {
                        testId = c.Int(nullable: false, identity: true),
                        testDescription = c.String(),
                    })
                .PrimaryKey(t => t.testId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestMigs");
        }
    }
}
