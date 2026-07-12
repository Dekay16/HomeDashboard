## EF Core Commands
First, make sure your Default project dropdown in PMC is set to:
- HomeDashboard.Data
- Install the EF Core tools if you haven't already

# Add migration:
Add-Migration InitialCreate

# Update database:
Update-Database

# Generate SQL
Script-Migration
- To save it to a file:
Script-Migration -Output "InitialCreate.sql"