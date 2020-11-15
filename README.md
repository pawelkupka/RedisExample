# RedisExample

## Instalacja Redis w Windows

Ściągnij https://github.com/microsoftarchive/redis/releases/download/win-3.2.100/Redis-x64-3.2.100.zip i uruchom redis-server.exe. To uruchomi serwer redis na porcie 6379

## Instalacja Redis za pomocą Dockera

cmd > docker run --name my-redis -p 5002:6379 -d redis

cmd > docker exec -it my-redis sh

## Instalacja klientów Redis do C#

Install-Package Microsoft.Extensions.Caching.StackExchangeRedis
