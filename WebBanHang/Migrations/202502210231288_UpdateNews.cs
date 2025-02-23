namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_News", "CreateBy", c => c.String());
            AddColumn("dbo.tb_News", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "ModifierDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_News", "ModifiedBy");
            DropColumn("dbo.tb_News", "ModifierDate");
            DropColumn("dbo.tb_News", "CreateDate");
            DropColumn("dbo.tb_News", "CreateBy");
        }
    }
}
