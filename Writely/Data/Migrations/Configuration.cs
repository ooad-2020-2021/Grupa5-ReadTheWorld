using System;

public class DbSeedData
{
    private MyDb _context;

    public DbSeedData(MyDb db)
    {
        _context = db;
    }

    protected override void Seed(Writely.Data.WritelyContext context)
    {
        context.Kategorija.SeedEnumValues<Kategorija, KategorijaEnum>(@enum => @enum);
        context.Žanr.SeedEnumValues<Žanr, ŽanrEnum>(@enum => @enum);
        context.StatusPrijave.SeedEnumValues<StatusPrijave, StatusPrijaveEnum>(@enum => @enum);
        context.Titula.SeedEnumValues<Titula, TitulaEnum>(@enum => @enum);
        context.SaveChanges();
    }


    public void EnsureSeedData()
    {
        if (!_context.Entities.Any())
        {
            {
                _context.Entities.Add(
                    new Entity { EntityName = "blabla" },
                    new Entity { EntityName = "blabla2" }
                 )
            }
        }
    }
}

