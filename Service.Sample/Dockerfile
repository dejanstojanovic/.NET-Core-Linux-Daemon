
FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
COPY ./publish/ ./
COPY ./sample.service /lib/systemd/system/
#ENTRYPOINT ["dotnet", "Service.Sample.dll"]

RUN apt-get update
RUN apt-get -y install systemd
RUN systemctl daemon-reload
RUN systemctl enable sample
RUN systemctl start sample
#EXPOSE 80
