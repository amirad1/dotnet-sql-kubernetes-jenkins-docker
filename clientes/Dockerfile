FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /src
COPY ["./clientes.csproj", "."]
RUN dotnet restore "./clientes.csproj"
COPY . .
WORKDIR /src/.
RUN dotnet build "./clientes.csproj" -c Release -o /app/build

FROM build as publish
RUN dotnet publish "./clientes.csproj" -c Release -o /app/publish

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "clientes.dll" ]