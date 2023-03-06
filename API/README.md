# Run docker command bellow to create the database

docker run -e 'HOMEBREW_NO_ENV_FILTERING=1' -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=password123!' -p 1433:1433 -d mcr.microsoft.com/azure-sql-edge:latest


# Run the backend project 

- Under API using the command bellow

dotnet run --project RoyalLibrary.Api


