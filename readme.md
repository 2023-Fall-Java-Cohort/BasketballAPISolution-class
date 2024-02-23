<p style="text-align: center"><image src="WECANCodeIT.png" /></p>

# Basketball Workshop
## Overview
The purpose of the application is to teach the student how an MVC website interfaces with Entity Framework in an Web API to build a basketball tracking site.

---

#### The Basketball Application
**Skills Used**
1. Data Model Project
2. API Web Controller Project
3. NUnit Test project
4. Inheritance
5. Entity Framework
6. Enum
7. Concurrency
8. one to many database relationship
9. many to one database relationship
10. many to many database relationship

## Iteration 1 Building an API Solution
## Step 1. Solution Setup
- Solution Name **BasketballSolution**
- Project 1 ASP.NET Core Web API  **BasketballAPI**

**Note:** The appsetting.json is used in this application
1. control the Database connection string
2. Log settings

**information on using different environments**
https://learn.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-7.0

There are 2 different appsettings 
- first one is used for "Release Builds" ==appsettings.json==
- second one is used for "Debug Builds" ==appsettings.Development.json==
- The Development setting will override the settings in "Release build" when useing the Debug.

==appsettings.Development.json==
```` html
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BasketBallApiDev;Trusted_Connection=True;"
  }
}
````
==appsettings.json==
```` html
{
  "Logging": {
    "LogLevel": {
      "Default": "Error",
      "Microsoft.AspNetCore": "Warning",
      "Microsoft.Hosting.Lifetime": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BasketBallApi;Trusted_Connection=True;"
  }
}
````

---
 ##### Add the following NuGet packages to the **BasketballAPI**
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
---
## Step 2. Data Models
Because the Web API project will be sharing data with an MVC Web Application, we need to place common data model code in a class library to be shared.

<p style="text-align: center"><image src="Database.png" /></p>

#### Create a Data Model project
    - Right Click on the BasketballSolution
    - Add>New Project
    - Click on class Library
    - Project Name   BasketBallDataModel

in the BasketballAPI make sure you add a project reference to the BasketballDataModel befor you continue.

#### Create folder Enums in Models Folder
1. Create public enum ==CoachTitle==
    - HEADCOACH
    - ASSTCOACH
    - TRAINER
    - MEDIC
    
**in a Models folder of the BasketballDataModel**

1. ==BaseModel== (abstract)
    - The Base Model will contain common properties of all the models
        - ==Id== Row Key 
        - ==UpdateOn== DateTime
        - ==CreatedOn== DateTime
        - ==RowVersion== Concurrency field
2. ==CocahModel== (Table Coachs)
    - This will inherit the BaseMode
    - Containts a reference to TeamModel
      - ==Name== string(100)
      - ==Title== enum CoachTitle default to HeadCoach
      - ==TeamId== int
3. ==PlayerModel== (Table Players)
    - This will inherit the BaseModel
     - Containt a reference to TeamModel
     - Containt a list reference to PositionModel through PlayerPositionModel
      - ==Name== String(100)
      - ==NationalRank== int
      - ==Birthdate== DateTime
      - ==Age== calculated based on Birthdate
      - ==IsActive== Boolean 
      - ==Salary== decimal
      - ==TeamId== int 
4. ==PositionModel== (Table Positions)
     - This will inherit the BaseModel
     - Containt a list reference to PlayerModel through PlayerPositionModel
     - Has a unique index to Name
       - ==Name== String(100)
5. ==TeamModel== (Table Teams)
    - This will inherit the BaseModel
    - Contains a list of CoachModel
    - Contains a list of PlayerModel
      - ==Name== string(100)
      - ==NationalRank== int
      - ==SeasonWins== int
      - ==SeasonLoss== int
      - ==NumberOfPlayers== calculated based on Players Count
6. ==PlayerPositionModel== (Table PlayerPositions)
    - This Table will be used to maintain the many to many relationship between the Players and positions
    - Contains a Reference to PlayerModel
    - Contains a Reference to PositonModel
      - ==PlayerId== int
      - ==PositionId== int
## Step 3. Data Context
---
#### create folder DataContext
**in the DataContext folder of the BasketballApi**
- #### we will use partial class's to make it easier to read
1. Create ==BasketballContext.cs==
- MAKE SURE YOU DECLARE THIS CLASS AS public partial class BasketballContext
- Add Constructor
  - DI ==IConfigure==
- override OnConfiguring (add the following)
````c#
 string? connectionString = configuration.GetConnectionString("DefaultConnection");
 if (connectionString != null)
 {
    optionsBuilder.UseSqlServer(connectionString);
 }
 else
{
    throw new InvalidOperationException("can not find Connection string DefaultConnection");
}
````
2. Create ==BasketballContext.DbSet.cs== (add the following)
- MAKE SURE YOU DECLARE THIS CLASS AS public partial class BasketballContext
````c#
public DbSet<CoachModel> Coachs { get; set; }
public DbSet<PlayerModel> Players { get; set; }
public DbSet<TeamModel> Teams { get; set; }
public DbSet<PositionModel> Positions { get; set; }
public DbSet<PlayerPositionModel> PlayerPositions { get; set; }
````
3. Create ==BasketballContext.Seed.cs== 
- MAKE SURE YOU DECLARE THIS CLASS AS public partial class BasketballContext
- overide OnModelCreating
```` c#
 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
    modelBuilder.Entity<PlayerPositionModel>()
                .HasKey(m => new { m.PlayerId, m.PositionId });
//add your seed data here
````
4. modify ==appsetting.json== (USED FOR RELEASE BUILDS)
```` html
 "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BasketBall;Trusted_Connection=True;"
  }
````
5. modify ==appsetting.Development.json== (USED FOR DEVELOPMENT BUILDS)
```` html
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BasketBallDev;Trusted_Connection=True;"
  }
}
````
6. Add database Context to DI
- in the program.cs add the following
- After builder.Services.AddSwaggerGen();

```` c#
// Add the Database context object
builder.Services.AddDbContext<BasketballContext>();
````

because the TeamsModel uses the PlayersModel which uses the TeamsModel which uses the PlayersModel... and on on on and on...

To prevent a possible object cycle was detected error.
you need to modifiy the builder.Services.AddControllers()

```` c#
// To prevent a possible object cycle was detected error.
builder.Services.AddControllers().AddJsonOptions(x =>
   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
````

This next step will be used when you are in a team. 

It will automaticly update-database for the migrations if it is needed. When the app is started

```` c#
#if DEBUG // Only run this part in development, this will not get built in a release edition
// Migrate latest database changes during startup
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider
        .GetRequiredService<BasketballContext>();

    // Here is the migration executed
    dbContext.Database.Migrate();
}
#endif

````

7. run Migration
- make sure you have added your default seed data
- in the ==Package Manager Console==
  - Add-Migration Initial

**Note** Because of the code we put in the Program.cs the Update-Database does not need to be executed, as long as the project is in Debug (Development) mode.

---
## Iteration 2 Building an API Controllers

 Right Click on Controllers Folder
- Select ==Add==
- Select ==Controller==
- Select ==API Controller using Entity Framework==
- Select Model class ==PlayerModel==
- Select DbContext class ==BasketballContext==
- Change Controller name to ==PlayersController==
- Click ==Add== button
- Add a Report Method which will produce a List Entities with refrence

<p style="text-align: center"><image src="PlayerController.png" /></p>

**Note:** follow these steps for all of the Table Models 

---

## Iteration 3 Building Data Model valdation test
We are only going to write data model valdation unit test. 

We are going to mock (fake) data entry by calling a ModelState function and testing the state of the model to see if it is valid.

- Right click on the BasketballSolution 
- Add>New Project
- NUnit Test Project
- Name BasketballTest

In the BasketballTest an a TestModels folder

Now we need a base class to contain methods that are common to all test. We need to use this class on all of the Data Models so we start with a Generic class.

- Right click on the TestModels in the BasketballTest project
- Add>Class
- Name ModelTest

This will be an abstract Generic class

```` c#
 /// <summary>
 /// abstract test used in test DataAnnotations validations
 /// </summary>
 /// <typeparam name="T">Data Model to test</typeparam>
 public abstract class ModelTest<T>
````

Next we call the mock validation method

```` c#
/// <summary>
/// Validated the Model accorrding to validation Attributes
/// </summary>
/// <param name="model">The Model to test</param>
/// <returns>List of Validation Results</returns>
protected IList<ValidationResult> ValidateModel(T model)
{
    var validationResults = new List<ValidationResult>();
    if (model is not null)
    {
        ValidationContext ctx = new(model, null, null);
        Validator.TryValidateObject(model, ctx, validationResults, true);
    }
    return validationResults;
}
````
Now weneed a common method to do a simple check on the Data Model class. We just need to count the number of validation errors.

```` c#
/// <summary>
/// Validated the model and returns the count of errors
/// </summary>
/// <param name="model">Error Count</param>
/// <returns></returns>
protected int CountErrors(T model)
{
    int retCount = 0;
    var list = ValidateModel(model);
    if (list != null)
    {
        retCount = list.Count;
    }
    return retCount;
}
````

#### You should follow the code examples for the test models


---
Strech task - Modify all Controllers 
- Exception Handling
- Logging
- Controller intergration Test with Memory SQL
---
