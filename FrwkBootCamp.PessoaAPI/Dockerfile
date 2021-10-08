#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["FrwkBootCamp.PessoaAPI/FrameBook.ProfissionalAPI.csproj", "FrwkBootCamp.PessoaAPI/"]
COPY ["FrwkBootCamp.Infra.Data/FrameBook.Infra.Data.csproj", "FrwkBootCamp.Infra.Data/"]
COPY ["FrwkBootCamp.Domain/FrameBook.Domain.csproj", "FrwkBootCamp.Domain/"]
COPY ["FrwkBootCamp.Application/FrameBook.Business.csproj", "FrwkBootCamp.Application/"]
COPY ["FrwkBootCamp.Application.DTO/FrameBook.Business.DTO.csproj", "FrwkBootCamp.Application.DTO/"]
COPY ["FrwBootCamp.Infra.CrossCutting.Adapter/FrameBook.Infra.CrossCutting.Adapter.csproj", "FrwBootCamp.Infra.CrossCutting.Adapter/"]
COPY ["FrwBootCamp.Infra.CrossCutting.IOC/FrameBook.Infra.CrossCutting.IOC.csproj", "FrwBootCamp.Infra.CrossCutting.IOC/"]
COPY ["FrwkBootCamp.Infra.Repository/FrameBook.Infra.Repository.csproj", "FrwkBootCamp.Infra.Repository/"]
RUN dotnet restore "FrwkBootCamp.PessoaAPI/FrameBook.ProfissionalAPI.csproj"
COPY . .
WORKDIR "/src/FrwkBootCamp.PessoaAPI"
RUN dotnet build "FrameBook.ProfissionalAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FrameBook.ProfissionalAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FrameBook.ProfissionalAPI.dll"]