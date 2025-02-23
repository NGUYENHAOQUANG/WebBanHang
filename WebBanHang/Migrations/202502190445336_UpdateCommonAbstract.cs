namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCommonAbstract : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Adv", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Adv", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Adv", "ModifierDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Adv", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Category", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Category", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Category", "ModifierDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Category", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Post", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Post", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Post", "ModifierDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Post", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Contact", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Contact", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Contact", "ModifierDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Contact", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Oder", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Oder", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Oder", "ModifierDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Oder", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Product", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Product", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Product", "ModifierDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_Product", "ModifiedBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_ProductCategori", "CreateBy", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_ProductCategori", "CreateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_ProductCategori", "ModifierDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.tb_ProductCategori", "ModifiedBy", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductCategori", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_ProductCategori", "ModifierDate", c => c.String());
            AlterColumn("dbo.tb_ProductCategori", "CreateDate", c => c.String());
            AlterColumn("dbo.tb_ProductCategori", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Product", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Product", "ModifierDate", c => c.String());
            AlterColumn("dbo.tb_Product", "CreateDate", c => c.String());
            AlterColumn("dbo.tb_Product", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Oder", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Oder", "ModifierDate", c => c.String());
            AlterColumn("dbo.tb_Oder", "CreateDate", c => c.String());
            AlterColumn("dbo.tb_Oder", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Contact", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Contact", "ModifierDate", c => c.String());
            AlterColumn("dbo.tb_Contact", "CreateDate", c => c.String());
            AlterColumn("dbo.tb_Contact", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Post", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Post", "ModifierDate", c => c.String());
            AlterColumn("dbo.tb_Post", "CreateDate", c => c.String());
            AlterColumn("dbo.tb_Post", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Category", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Category", "ModifierDate", c => c.String());
            AlterColumn("dbo.tb_Category", "CreateDate", c => c.String());
            AlterColumn("dbo.tb_Category", "CreateBy", c => c.String());
            AlterColumn("dbo.tb_Adv", "ModifiedBy", c => c.String());
            AlterColumn("dbo.tb_Adv", "ModifierDate", c => c.String());
            AlterColumn("dbo.tb_Adv", "CreateDate", c => c.String());
            AlterColumn("dbo.tb_Adv", "CreateBy", c => c.String());
        }
    }
}
