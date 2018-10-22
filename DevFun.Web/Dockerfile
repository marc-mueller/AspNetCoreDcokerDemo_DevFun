FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY DevFun.Web/DevFun.Web.csproj DevFun.Web/
COPY DevFun.Common/DevFun.Common.csproj DevFun.Common/
RUN dotnet restore DevFun.Web/DevFun.Web.csproj
COPY . .
WORKDIR /src/DevFun.Web
RUN dotnet build DevFun.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DevFun.Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DevFun.Web.dll"]
