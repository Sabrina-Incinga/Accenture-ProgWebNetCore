namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relaciones : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumno", "ProfesorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Alumno", "ProfesorId");
            AddForeignKey("dbo.Alumno", "ProfesorId", "dbo.Profesor", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "ProfesorId", "dbo.Profesor");
            DropIndex("dbo.Alumno", new[] { "ProfesorId" });
            DropColumn("dbo.Alumno", "ProfesorId");
        }
    }
}
