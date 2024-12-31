using ExomineApi.Modals;
using ExomineApi.Modals.DTOs;
using Microsoft.AspNetCore.Authorization.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

List<Colony> colonies = new List<Colony>()
{
    new Colony()
        {
            Id = 1,
            Name = "Terra Prime"
        },
    new Colony()
    {
        Id = 2,
        Name = "Red Horizon"
    },
    new Colony()
    {
        Id = 3,
        Name = "Europa Haven"
    },
    new Colony()
    {
        Id = 4,
        Name = "Titan Colony"
    },
    new Colony()
    {
        Id = 5,
        Name = "New Elysium"
    }
};

List<Governor> governors = new List<Governor>()
{
    new Governor()
    {
        Id = 1,
        Name = "John Matthis",
        ActiveStatus = true,
        ColonyId = 1
    },
    new Governor()
    {
        Id = 2,
        Name = "Serena Kallin",
        ActiveStatus = true,
        ColonyId = 1
    },
    new Governor()
    {
        Id = 3,
        Name = "Alexis Gray",
        ActiveStatus = true,
        ColonyId = 2
    },
    new Governor()
    {
        Id = 4,
        Name = "Markus Vega",
        ActiveStatus = false,
        ColonyId = 2
    },
    new Governor()
    {
        Id = 5,
        Name = "Diana Wells",
        ActiveStatus = true,
        ColonyId = 3
    },
    new Governor()
    {
        Id = 6,
        Name = "Victor Steele",
        ActiveStatus = true,
        ColonyId = 4
    },
    new Governor()
    {
        Id = 7,
        Name = "Carter Blaze",
        ActiveStatus = false,
        ColonyId = 5
    }
};

List<Facility> facilities = new List<Facility>()
{
    new Facility()
    {
        Id = 1,
        Name = "Asteroid X-22 Mining Corp",
        ActiveStatus = true
    },
    new Facility()
    {
        Id = 2,
        Name = "Lunar Excavation Hub",
        ActiveStatus = false
    },
    new Facility()
    {
        Id = 3,
        Name = "Titanium Ridge Mine",
        ActiveStatus = true
    },
    new Facility()
    {
        Id = 4,
        Name = "Helium Harvesters",
        ActiveStatus = true
    },
    new Facility()
    {
        Id = 5,
        Name = "Kuiper Belt Ore Syndicate",
        ActiveStatus = false
    }
};

List<Mineral> minerals = new List<Mineral>()
{
    new Mineral()
    {
        Id = 1,
        Name = "Helium-3"
    },
     new Mineral()
    {
        Id = 2,
        Name = "Titanium"
    },
     new Mineral()
    {
        Id = 3,
        Name = "Iron"
    },
     new Mineral()
    {
        Id = 4,
        Name = "Magnesium"
    },
     new Mineral()
    {
        Id = 5,
        Name = "Platinum"
    },
     new Mineral()
    {
        Id = 6,
        Name = "Silicon"
    }
};

List<ColonyMineral> colonyMinerals = new List<ColonyMineral>()
{
    new ColonyMineral()
    {
        Id = 1,
        ColonyId = 1,
        MineralId = 1,
        Count = 26
    },
    new ColonyMineral()
    {
        Id = 2,
        ColonyId = 5,
        MineralId = 6,
        Count = 15
    },
    new ColonyMineral()
    {
        Id = 3,
        ColonyId = 3,
        MineralId = 3,
        Count = 12
    },
    new ColonyMineral()
    {
        Id = 4,
        ColonyId = 5,
        MineralId = 5,
        Count = 20
    },
    new ColonyMineral()
    {
        Id = 5,
        ColonyId = 2,
        MineralId = 5,
        Count = 11
    },
    new ColonyMineral()
    {
        Id = 6,
        ColonyId = 4,
        MineralId = 6,
        Count = 9
    },
    new ColonyMineral()
    {
        Id = 7,
        ColonyId = 1,
        MineralId = 2,
        Count = 15
    },
    new ColonyMineral()
    {
        Id = 8,
        ColonyId = 3,
        MineralId = 4,
        Count = 8
    },
    new ColonyMineral()
    {
        Id = 9,
        ColonyId = 4,
        MineralId = 2,
        Count = 12
    },
    new ColonyMineral()
    {
        Id = 10,
        ColonyId = 2,
        MineralId = 1,
        Count = 8
    },
    new ColonyMineral()
    {
        Id = 11,
        ColonyId = 3,
        MineralId = 1,
        Count = 4
    },
    new ColonyMineral()
    {
        Id = 12,
        ColonyId = 1,
        MineralId = 3,
        Count = 2
    }
};

List<FacilityMineral> facilityMinerals = new List<FacilityMineral>()
{
    new FacilityMineral()
    {
        Id = 1,
        FacilityId = 1,
        MineralId = 1,
        Count = 0
    },
     new FacilityMineral()
    {
        Id = 2,
        FacilityId = 4,
        MineralId = 3,
        Count = 14
    },
     new FacilityMineral()
    {
        Id = 3,
        FacilityId = 2,
        MineralId = 6,
        Count = 15
    },
     new FacilityMineral()
    {
        Id = 4,
        FacilityId = 5,
        MineralId = 5,
        Count = 55
    },
     new FacilityMineral()
    {
        Id = 5,
        FacilityId = 5,
        MineralId = 6,
        Count = 17
    },
     new FacilityMineral()
    {
        Id = 6,
        FacilityId = 3,
        MineralId = 4,
        Count = 28
    },
     new FacilityMineral()
    {
        Id = 7,
        FacilityId = 2,
        MineralId = 2,
        Count = 20
    },
     new FacilityMineral()
    {
        Id = 8,
        FacilityId = 1,
        MineralId = 3,
        Count = 50
    },
     new FacilityMineral()
    {
        Id = 9,
        FacilityId = 4,
        MineralId = 1,
        Count = 88
    },
     new FacilityMineral()
    {
        Id = 10,
        FacilityId = 3,
        MineralId = 2,
        Count = 2
    }
};
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/colonyMinerals", (int? colonyId) => {

    List<ColonyMineral> foundMinerals = colonyId.HasValue
    ? colonyMinerals.Where(cm => cm.ColonyId == colonyId).ToList() : colonyMinerals;

    return Results.Ok(foundMinerals.Select(fm => new ColonyMineralDTO
    {
        Id = fm.Id,
        ColonyId = fm.ColonyId,
        MineralId = fm.MineralId,
        Count = fm.Count
    }));
});

app.MapGet("/facilityMinerals", (int? facilityId, int? mineralId) => 
{
    List<FacilityMineral> foundMineral = facilityId.HasValue && mineralId.HasValue 
    ? facilityMinerals.Where(fm => fm.FacilityId == facilityId).Where(m => m.MineralId == mineralId).ToList() : facilityMinerals;

    return Results.Ok(foundMineral.Select(fm => new FacilityMineralDTO
    {
        Id = fm.Id,
        FacilityId = fm.FacilityId,
        MineralId = fm.MineralId,
        Count = fm.Count
    }));
});

app.MapPost("/colonyMinerals", (ColonyMineral coloniesMineral) => {

    coloniesMineral.Id = colonyMinerals.Max(cm => cm.Id) + 1;
    colonyMinerals.Add(coloniesMineral);
    coloniesMineral.Count = 1;

    return Results.Created($"/colonyMinerals/{coloniesMineral.Id}", new ColonyMineralDTO{
        Id = coloniesMineral.Id,
        ColonyId = coloniesMineral.ColonyId,
        MineralId = coloniesMineral.MineralId,
        Count = coloniesMineral.Count
    });
});

app.MapPut("/colonyMinerals/{id}", (int id, ColonyMineral coloniesMineral) => {
    ColonyMineral foundMineral = colonyMinerals.FirstOrDefault(cm => cm.Id == id);
    
    if (foundMineral == null)
    {
        return Results.NotFound();
    }

    foundMineral.Id = id;
    foundMineral.ColonyId = coloniesMineral.ColonyId;
    foundMineral.MineralId = coloniesMineral.MineralId;
    foundMineral.Count = coloniesMineral.Count + 1;

    return Results.Ok(new ColonyMineralDTO {
        Id = foundMineral.Id,
        ColonyId = coloniesMineral.ColonyId,
        MineralId = foundMineral.MineralId,
        Count = foundMineral.Count
    });
});

app.MapPut("/facilityMinerals/{id}", (int id, FacilityMineral facilitiesMineral) => {
    FacilityMineral foundMineral = facilityMinerals.FirstOrDefault(fm => fm.Id == id);

    if (foundMineral == null)
    {
        return Results.NotFound();
    }

    foundMineral.Id = id;
    foundMineral.FacilityId = facilitiesMineral.FacilityId;
    foundMineral.MineralId = facilitiesMineral.MineralId;
    foundMineral.Count = facilitiesMineral.Count - 1;

    return Results.Ok(new FacilityMineralDTO
    {
        Id = id,
        FacilityId = foundMineral.FacilityId,
        MineralId = foundMineral.MineralId,
        Count = foundMineral.Count
    });
});


app.Run();

