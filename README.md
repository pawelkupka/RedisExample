# RedisExample

## Instalacja Redis w Windows

Ściągnij i uruchom server Redis https://github.com/microsoftarchive/redis/releases/tag/win-3.2.100

## Instalacja Redis za pomocą Dockera

cmd > docker run --name my-redis -p 5002:6379 -d redis

cmd > docker exec -it my-redis sh

## Instalacja klientów Redis do C#

Install-Package Microsoft.Extensions.Caching.StackExchangeRedis

Install-Package StackExchange.Redis
