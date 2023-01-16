namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categorias", newName: "Categoria");
            AlterColumn("dbo.Categoria", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categoria", "Nombre", c => c.String());
            RenameTable(name: "dbo.Categoria", newName: "Categorias");
        }
    }
}
