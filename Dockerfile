FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /build
COPY . .
RUN dotnet build -c Release

FROM build AS publish
RUN dotnet publish -c Release -o out

FROM base AS final
WORKDIR /app
COPY --from=publish /build/out .

ENTRYPOINT ["dotnet", "Wallet.BlazorUI.dll"]
#RUN dotnet run app/Wallet.BlazorUI.dll
