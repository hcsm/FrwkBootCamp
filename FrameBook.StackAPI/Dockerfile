#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["FrameBook.StackAPI/FrameBook.StackAPI.csproj", "FrameBook.StackAPI/"]
COPY ["FrwkBootCamp.Infra.Data/FrameBook.Infra.Data.csproj", "FrwkBootCamp.Infra.Data/"]
COPY ["FrwkBootCamp.Domain/FrameBook.Domain.csproj", "FrwkBootCamp.Domain/"]
COPY ["FrwBootCamp.Infra.CrossCutting.IOC/FrameBook.Infra.CrossCutting.IOC.csproj", "FrwBootCamp.Infra.CrossCutting.IOC/"]
COPY ["FrwkBootCamp.Application/FrameBook.Business.csproj", "FrwkBootCamp.Application/"]
COPY ["FrwkBootCamp.Application.DTO/FrameBook.Business.DTO.csproj", "FrwkBootCamp.Application.DTO/"]
COPY ["FrwBootCamp.Infra.CrossCutting.Adapter/FrameBook.Infra.CrossCutting.Adapter.csproj", "FrwBootCamp.Infra.CrossCutting.Adapter/"]
COPY ["FrwkBootCamp.Infra.Repository/FrameBook.Infra.Repository.csproj", "FrwkBootCamp.Infra.Repository/"]
RUN dotnet restore "FrameBook.StackAPI/FrameBook.StackAPI.csproj"
COPY . .
WORKDIR "/src/FrameBook.StackAPI"
RUN dotnet build "FrameBook.StackAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FrameBook.StackAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FrameBook.StackAPI.dll"]