# Dockerfile for CatchUpPlatform.API
# Summary: 
# This Dockerfile builds and runs the CatchUpPlatform.API application using .NET 9.0
# Description:
# This Dockerfile is designed to create a Docker image for the CatchUpPlatform.API application.
# It uses a multi-stage build process to first compile the application using the .NET SDK,
# and then run it using the .NET runtime. The final image is lightweight and contains only the necessary files to run the application.
# Version: 1.0
# Maintainer: Web Application Team

# Step 1: Build the application
# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS builder
# Set the working directory in the container
WORKDIR /app
# Copy the project files
# Copy the project files and restore dependencies
COPY CatchUpPlatform.API/*.csproj CatchUpPlatform.API/
# Restore dependencies
RUN dotnet restore ./CatchUpPlatform.API
# Copy the rest of the application files
COPY . .

# Step 2: Deploy the application to builder stage
# Publish the application in Release mode
RUN dotnet publish ./CatchUpPlatform.API -c Release -o out

# Step 3: Publish to Production and Run the application
# Use the official .NET runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:9.0
# Set the working directory in the container
WORKDIR /app
# Copy the published application from the builder stage
COPY --from=builder /app/out .
EXPOSE 80
# Set EntryPoint to run the application
ENTRYPOINT ["dotnet", "CatchUpPlatform.API.dll"]
# Note: The application will run with the 'Production' ASP.NET active environment.
# This Dockerfile is designed to be used in a CI/CD pipeline or for local development.
# It is necessary to define the following environment variables in the hosting provider for the application to
# run correctly in the Production environment:
# - DATABASE_SCHEMA: The name of the database to connect to.
# - DATABASE_USER: The username for the database connection.
# - DATABASE_PASSWORD: The password for the database connection.
# - DATABASE_PORT: The port for the database connection.
# - DATABASE_URL: The URL of the database to connect to.
