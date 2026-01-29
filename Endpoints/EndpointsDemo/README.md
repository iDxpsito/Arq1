# COMO SE CREO EL ARCHIVO 
dotnet new webapi -n EndpointsDemo

# ACCEDER A LA CARPETAdo
cd .\EndpointsDemo

# INSTALAR SWAGGER (versión compatible con .NET 8)
# Se usa para documentar y probar los endpoints desde el navegador
dotnet add package Swashbuckle.AspNetCore --version 6.5.0

# ELIMINAR SWAGGER
# Útil cuando hay errores de versión o conflictos de dependencias
dotnet remove package Swashbuckle.AspNetCore

# ELIMINAR OPENAPI ANTIGUO
# Evita errores como TypeLoadException
dotnet remove package Microsoft.OpenApi

# LIMPIAR EL PROYECTO
# Borra archivos compilados antiguos (bin y obj)
dotnet clean

# RESTAURAR PAQUETES
# Vuelve a descargar todas las dependencias necesarias
dotnet restore

# CORRE EL PROYECTO
dotnet run