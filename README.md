# BookingTripProjectSystem
 To Run Application :
You Must install This Packages
BookingTrip.Api --->
1-"Microsoft.EntityFrameworkCore" Version="5.0.9"
2-"Microsoft.EntityFrameworkCore.SqlServer" Version="5.0.9"
3-"Microsoft.EntityFrameworkCore.Tools" Version="5.0.9"


BookingTrip.Application -->
1-AutoMapper.Extensions.Microsoft.DependencyInjection" Version="8.1.1"
2-FluentValidation" Version="10.3.0
3-MediatR.Extensions.Microsoft.DependencyInjection" Version="9.0.0

BookingTrip.Persistence -->
1-Microsoft.EntityFrameworkCore" Version="5.0.9
2-Microsoft.EntityFrameworkCore.SqlServer Version="5.0.9"
3-"Microsoft.EntityFrameworkCore.Tools" Version="5.0.9"



--then Go To Package Manager Console 
1-make BookingTrip.Persistence Default Project 
2- remove old migration
3- add-migration IntialMigration
4-Update Database


** set BookingTrip.Api as Startup Project
and Then Run .
