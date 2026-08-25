#!/usr/bin/env bash
set -euo pipefail

repository_directory=$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)
native_cli=${1:?Native CLI executable path is required.}
managed_cli=${2:?Managed CLI assembly path is required.}

native_cli=$(cd "$(dirname "$native_cli")" && pwd)/$(basename "$native_cli")
managed_cli=$(cd "$(dirname "$managed_cli")" && pwd)/$(basename "$managed_cli")
acceptance_directory=$(mktemp -d)
trap 'rm -rf "$acceptance_directory"' EXIT

run_managed() {
  dotnet "$managed_cli" "$@"
}

run_native() {
  "$native_cli" "$@"
}

compare_generated() {
  local label=$1
  local spec=$2
  local namespace=$3
  local managed_output="$acceptance_directory/$label-managed"
  local native_output="$acceptance_directory/$label-native"

  run_managed generate "$spec" \
    --namespace "$namespace" \
    --targetFramework net10.0 \
    --output "$managed_output" \
    --ignore-openapi-errors \
    --ignore-openapi-warnings >/dev/null
  run_native generate "$spec" \
    --namespace "$namespace" \
    --targetFramework net10.0 \
    --output "$native_output" \
    --ignore-openapi-errors \
    --ignore-openapi-warnings >/dev/null
  diff -ru "$managed_output" "$native_output"
}

managed_version=$(run_managed --version)
native_version=$(run_native --version)
test "$managed_version" = "$native_version"

for format in tsv json; do
  run_managed audit-representations \
    "$repository_directory/specs/native-aot-representations.yaml" \
    --format "$format" \
    --output "$acceptance_directory/representations-managed.$format"
  run_native audit-representations \
    "$repository_directory/specs/native-aot-representations.yaml" \
    --format "$format" \
    --output "$acceptance_directory/representations-native.$format"
  cmp \
    "$acceptance_directory/representations-managed.$format" \
    "$acceptance_directory/representations-native.$format"
done

compare_generated openapi30-yaml "$repository_directory/specs/petstore.yaml" NativeAot.OpenApi30Yaml
compare_generated openapi30-json "$repository_directory/specs/native-aot-openapi30.json" NativeAot.OpenApi30Json
compare_generated openapi31-yaml "$repository_directory/specs/callbacks-webhooks-links.yaml" NativeAot.OpenApi31Yaml
compare_generated openapi31-json "$repository_directory/specs/native-aot-openapi31.json" NativeAot.OpenApi31Json
compare_generated asyncapi-yaml "$repository_directory/specs/native-aot-asyncapi.yaml" NativeAot.AsyncApiYaml
compare_generated asyncapi-json "$repository_directory/specs/native-aot-asyncapi.json" NativeAot.AsyncApiJson

run_managed http "$repository_directory/specs/callbacks-webhooks-links.yaml" \
  --output "$acceptance_directory/http-managed" \
  --ignore-openapi-errors \
  --ignore-openapi-warnings >/dev/null
run_native http "$repository_directory/specs/callbacks-webhooks-links.yaml" \
  --output "$acceptance_directory/http-native" \
  --ignore-openapi-errors \
  --ignore-openapi-warnings >/dev/null
diff -ru "$acceptance_directory/http-managed" "$acceptance_directory/http-native"

for runtime in managed native; do
  output="$acceptance_directory/cli-$runtime"
  if [[ "$runtime" == managed ]]; then
    run_managed cli-project "$repository_directory/specs/native-aot-openapi30.json" \
      --api-only \
      --output "$output" \
      --sdk-project "$repository_directory/src/libs/AutoSDK.CLI/AutoSDK.CLI.csproj" \
      --namespace NativeAot.OpenApi30Json \
      --clientClassName NativeAotClient \
      --ignore-openapi-errors \
      --ignore-openapi-warnings >/dev/null
  else
    run_native cli-project "$repository_directory/specs/native-aot-openapi30.json" \
      --api-only \
      --output "$output" \
      --sdk-project "$repository_directory/src/libs/AutoSDK.CLI/AutoSDK.CLI.csproj" \
      --namespace NativeAot.OpenApi30Json \
      --clientClassName NativeAotClient \
      --ignore-openapi-errors \
      --ignore-openapi-warnings >/dev/null
  fi
done
diff -ru -I 'UserSecretsId = ' \
  "$acceptance_directory/cli-managed" \
  "$acceptance_directory/cli-native"

create_docs_fixture() {
  local root=$1
  mkdir -p "$root/docs" "$root/src/libs/NativeAot" "$root/src/tests/IntegrationTests/Examples"
  printf '%s\n' '# NativeAOT' '' '<!-- EXAMPLES:START -->' '<!-- EXAMPLES:END -->' > "$root/README.md"
  printf '%s\n' 'nav:' '- Overview: index.md' '# EXAMPLES:START' '# EXAMPLES:END' > "$root/mkdocs.yml"
  printf '%s\n' '<Project Sdk="Microsoft.NET.Sdk" />' > "$root/src/libs/NativeAot/NativeAot.csproj"
  printf '%s\n' \
    '/*' \
    'title: Native AOT Example' \
    'order: 1' \
    '' \
    'Runs through native docs synchronization.' \
    '*/' \
    'namespace NativeAot.IntegrationTests;' \
    'public partial class Tests' \
    '{' \
    '    [TestMethod]' \
    '    public async Task NativeAotExample()' \
    '    {' \
    '        using var client = GetAuthenticatedClient();' \
    '        await client.RunAsync();' \
    '    }' \
    '}' > "$root/src/tests/IntegrationTests/Examples/NativeAotExample.cs"
}

create_docs_fixture "$acceptance_directory/docs-managed"
create_docs_fixture "$acceptance_directory/docs-native"
run_managed docs sync "$acceptance_directory/docs-managed" >/dev/null
run_native docs sync "$acceptance_directory/docs-native" >/dev/null
diff -ru "$acceptance_directory/docs-managed" "$acceptance_directory/docs-native"

echo "NativeAOT CLI acceptance passed for $native_version."
