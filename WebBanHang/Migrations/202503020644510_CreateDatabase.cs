namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
            "dbo.ThongKe",
            c => new
            {
                Id = c.Int(nullable: false, identity: true),
                Name = c.String(),
                CreatedDate = c.DateTime(nullable: false)
            })
            .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.ThongKe");
        }
    }
}
