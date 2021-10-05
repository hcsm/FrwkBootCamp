#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Web.FrameBook.HttpAggregator/Web.FrameBook.HttpAggregator.csproj", "Web.FrameBook.HttpAggregator/"]
RUN dotnet restore "Web.FrameBook.HttpAggregator/Web.FrameBook.HttpAggregator.csproj"
COPY . .
WORKDIR "/src/Web.FrameBook.HttpAggregator"
RUN dotnet build "Web.FrameBook.HttpAggregator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Web.FrameBook.HttpAggregator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Web.FrameBook.HttpAggregator.dll"]