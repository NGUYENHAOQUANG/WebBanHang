namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNews1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_News", "Detail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_News", "Detail");
        }
    }
}
