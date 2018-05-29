#FROM microsoft/aspnetcore:2.0 AS base
#WORKDIR /app
#EXPOSE 80
#
#FROM microsoft/aspnetcore-build:2.0 AS build
#WORKDIR /src
#COPY DynamicModel.Core.sln ./
#COPY DynamicModel.Core.Web.Api/DynamicModel.Core.Web.Api.csproj DynamicModel.Core.Web.Api/
#COPY DynamicModel.Core.Data/DynamicModel.Core.Data.csproj DynamicModel.Core.Data/
#RUN dotnet restore -nowarn:msb3202,nu1503
#COPY . .
#WORKDIR /src/DynamicModel.Core.Web.Api
#RUN dotnet build -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "DynamicModel.Core.Web.Api.dll"]



FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
COPY ./publish/ ./
ENTRYPOINT ["dotnet", "Service.Sample.dll"]
EXPOSE 80


##BUILD PROJECT WITH BUILD IMAGE
#FROM microsoft/aspnetcore-build:2.0 AS build
#WORKDIR /build
#COPY . .
#RUN dotnet restore
#RUN dotnet publish -c Release -o output

##BUILD RUN IMAGE
#FROM microsoft/aspnetcore:2.0
#WORKDIR /app
#COPY --from=build /build/output .
#ENTRYPOINT ["dotnet", "DynamicModel.Core.Web.Api.dll"]
#EXPOSE 80