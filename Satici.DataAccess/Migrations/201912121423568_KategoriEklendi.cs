namespace Satici.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KategoriEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Satici.Kategori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Satici.Kategori");
        }
    }
}
