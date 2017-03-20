using System;
using System.Linq;
using EASY.Crud.Entity.Model;

namespace EASY.Crud.Entity.Migrations.Seed
{
    public static class SeedInit
    {
        public static void InitiateKnowledge()
        {
            using (var db = new Context())
            {
                if (db.KnowledgeBase.Any()) return;

                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Ionic" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Android" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "IOS" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "HTML" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "CSS" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Bootstrap" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Jquery" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "AngularJs" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Java" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Asp.Net MVC" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "C" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "C++" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Cake" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Django" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Majento" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "PHP" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Wordpress" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Phyton" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Ruby" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "SQL Server" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "My SQL" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Salesforce" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Photoshop" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "Illustrator" } );
                db.KnowledgeBase.Add(new KnowledgeBase {CreatedAt = DateTime.UtcNow, Name = "SEO" } );

                db.SaveChanges();
            }
        }
    }
}