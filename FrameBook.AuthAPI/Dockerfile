#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FrameBook.AuthAPI/FrameBook.AuthAPI.csproj", "FrameBook.AuthAPI/"]
RUN dotnet restore "FrameBook.AuthAPI/FrameBook.AuthAPI.csproj"
COPY . .
WORKDIR "/src/FrameBook.AuthAPI"
RUN dotnet build "FrameBook.AuthAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FrameBook.AuthAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FrameBook.AuthAPI.dll"]