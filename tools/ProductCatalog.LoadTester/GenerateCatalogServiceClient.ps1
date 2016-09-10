# Stop on first error
$ErrorActionPreference = 'Stop'

$swaggerFile        = Join-Path $env:TEMP 'CatalogService.Swagger.json'
$swaggerUrl         = 'http://localhost:26928/swagger/v1/swagger.json'
$generatedNamespace = 'ProductCatalog.LoadTester.Generated'

Invoke-WebRequest $swaggerUrl -OutFile $swaggerFile
AutoRest.exe -codegenerator CSharp -Modeler Swagger -input $swaggerFile -Namespace $generatedNamespace -OutputDirectory (Join-Path $PSScriptRoot 'Generated')
