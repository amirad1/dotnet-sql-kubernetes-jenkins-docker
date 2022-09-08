#!/bin/sh

#test database container working propely
docker exec SQL-CONT /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P MyP@ssw0rd123

if [ $? -eq 0 ];

then

echo "Database its workiiiing"

else 

echo "Databse failed sir"

fi



