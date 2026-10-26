dotnet tool install --global autosdk.cli --prerelease
curl -o openapi.yaml $OpenApiSpec$
autosdk generate openapi.yaml \
  --namespace $SolutionName$ \
  --clientClassName $ClientName$ \
  --targetFramework net10.0 \
  --output Generated \
  --shared-json-metadata \
  --shared-json-metadata-project $SolutionName$.csproj \
  --clean-stale-files \
  --exclude-deprecated-operations
