﻿namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateposst : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Post", "Detail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Post", "Detail");
        }
    }
}
