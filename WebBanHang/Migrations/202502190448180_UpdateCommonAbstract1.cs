namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCommonAbstract1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Adv", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Adv", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Category", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Category", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Post", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Post", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Contact", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Contact", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Oder", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Oder", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Product", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Product", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_ProductCategori", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_ProductCategori", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductCategori", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_ProductCategori", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Product", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Product", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Oder", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Oder", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Contact", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Contact", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Post", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Post", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Category", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Category", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Adv", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Adv", "CreateBy", c => c.DateTime(nullable: false));
        }
    }
}
