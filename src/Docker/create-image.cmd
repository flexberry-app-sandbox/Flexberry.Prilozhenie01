docker build --no-cache -f SQL\Dockerfile.PostgreSql -t prilozhenie_01/postgre-sql ../SQL

docker build --no-cache -f Dockerfile -t prilozhenie_01/app ../..
