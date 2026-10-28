# TournamentTracker

A Windows Forms application for organizing tournaments: teams, team members, prizes and match-up rounds. The forms for the dashboard, tournament creation, team creation and tournament viewer are designed, and creating prizes is wired up to a SQL Server database through Dapper.

## Tech Stack

- .NET 5 (`net5.0` class library, `net5.0-windows` Windows Forms app)
- Dapper 2.0 with `System.Data.SqlClient`
- `System.Configuration.ConfigurationManager` (connection string in `App.config`)
- SQL Server (Express)

## Project Structure

| Project | Description |
| --- | --- |
| `TrackerLibrary` | Class library with the models (`TournamentModel`, `TeamModel`, `Person`, `PrizeModel`, `MatchUpModel`, `MatchUpEntryModel`), the `IDataConnection` abstraction with a SQL Server (`SQLConnector`) and a text-file (`TextConnection`, not implemented yet) implementation, and `GlobalConfig`, which selects the data source and reads connection strings. |
| `ProjectTrackerUI` | Windows Forms app: Create Prize, Create Team, Create Tournament, Tournament Dashboard and Tournament Viewer forms. Starts on the Create Prize form. |

Other folders: `DataBase` contains the entity-relationship diagram of the database, and `Photos` contains the images used by the forms.

## Features

- Create a prize (place number, place name, prize amount or prize percentage) with input validation; the prize is saved through the `Prizes_Info` stored procedure and gets its generated id back.
- Data source abstraction so the storage can be switched between SQL Server and text files (`GlobalConfig.InitializeConnections`).
- Designed forms for creating teams (with team members), creating tournaments, the tournament dashboard and the tournament viewer. These forms have no logic behind them yet.

## Getting Started

### Prerequisites

- Windows
- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0) (or Visual Studio 2019/2022 with the .NET desktop workload)
- SQL Server Express

### Database

The connection string `Tournaments` is in `ProjectTrackerUI/App.config`:

```xml
<add name="Tournaments" connectionString="Data Source=.\sqlexpress;Initial Catalog=Tournaments;DataBase=Tournaments;Integrated Security=True ;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
```

Create a `Tournaments` database following the diagram in `DataBase/Entity_Relation_Ship_model.png`, including the `Prizes_Info` stored procedure with these parameters:

```sql
@PlaceNumber int,
@PlaceName nvarchar(150),
@PrizeAmount money,
@PrizePercentage float,
@id int = 0 output
```

### Run

Open `TournamentTracker.sln` in Visual Studio and start `ProjectTrackerUI`, or:

```bash
dotnet run --project ProjectTrackerUI
```
