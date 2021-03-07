# Solar Coffee

Solar Coffee Project

I originally worked the tutorial for this from a Udemy course. I am now using this project as a way to study for my AWS Associate Dev certification by trying to use the AWS Services for this application and get it all hosted and working.


# Postgres helpful commands

* Creating a User & DB.
CREATE USER <user> WITH PASSWORD '<password>';
CREATE DATABASE <dbname>;
GRANT ALL PRIVILEGES ON <dbname> TO <user>;

\c <dbname> <user>

* CLI DB Migrations (Be in .Data project since that is what connects to the DB).
1.) dotnet ef --startup-project ../SolarCoffee.Web migrations add InitialMigration
2.) dotnet ef --startup-project ../SolarCoffee.Web database update