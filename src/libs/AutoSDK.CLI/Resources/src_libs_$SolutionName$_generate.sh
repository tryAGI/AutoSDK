dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml $OpenApiSpec$
autosdk generate openapi.yaml \
  --namespace $SolutionName$ \
  --clientClassName $ClientName$ \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
