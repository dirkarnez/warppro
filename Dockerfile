FROM mcr.microsoft.com/dotnet/framework/sdk:4.8

WORKDIR /app

COPY . .
RUN nuget restore .
RUN msbuild /p:Configuration=Release /p:OutputPath=C:\app\out\

ENTRYPOINT ["/app/out/WarpPro.exe"]
