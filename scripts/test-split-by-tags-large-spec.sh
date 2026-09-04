#!/usr/bin/env bash

# Generates a large specification as a split-by-tags package family and builds it.
#
# The two-tag fixture in AutoSDK.IntegrationTests.Cli proves the mode's mechanics, but every
# routing defect found so far came from a real specification instead: type names that prefix one
# another, union converters that cannot move, and a schema graph whose depth and cycle limits make
# reachability under-report. Those only appear at this scale, so they need a check at this scale.

set -euo pipefail

spec=${1:-specs/github.yaml}
namespace=${2:-GitHub}
client=${3:-GitHubClient}
package_id=${4:-tryAGI.GitHub}
configuration=${CONFIGURATION:-Release}
output=${SPLIT_BY_TAGS_OUTPUT:-artifacts/split-by-tags}

if [[ ! -f $spec ]]; then
  echo "Specification '$spec' not found." >&2
  exit 2
fi

rm -rf "$output"

echo "Generating $spec as a package family..."
dotnet run --framework net10.0 --project src/libs/AutoSDK.CLI -- \
  generate "$spec" \
  --namespace "$namespace" \
  --clientClassName "$client" \
  --targetFramework net10.0 \
  --output "$output" \
  --split-by-tags \
  --package-id "$package_id" \
  --clean-stale-files

packages_root="$output/GeneratedPackages"
solution="$packages_root/$package_id.slnx"

if [[ ! -f $solution ]]; then
  echo "Expected solution '$solution' was not generated." >&2
  exit 1
fi

# Building the solution is the assertion. A model routed into a package that cannot see it, a
# serializer context registering a type from another assembly, or a converter left behind all fail
# here and nowhere else.
echo "Building $(basename "$solution")..."
build_log="$output/build.log"
set +e
dotnet build --disable-build-servers --configuration "$configuration" "$solution" 2>&1 | tee "$build_log"
build_status=${PIPESTATUS[0]}
set -e

if [[ $build_status -ne 0 ]]; then
  exit "$build_status"
fi

# A tag context registers only its own share and lets System.Text.Json discover the rest of the
# family implicitly, so a name the two halves of a collision share would surface here as SYSLIB1031.
# Generation adds the family-wide colliding types to every context to prevent that; this is the
# check that it kept working, because the warning is invisible in a single-project build.
collisions=$(grep -c "SYSLIB1031" "$build_log" || true)
echo
echo "System.Text.Json name collisions across package contexts (SYSLIB1031): $collisions"
if [[ $collisions -ne 0 ]]; then
  echo "Expected none. A consumer building with TreatWarningsAsErrors would fail on these." >&2
  exit 1
fi

echo
echo "Package family file counts:"
python3 - "$packages_root/autosdk-packages.json" <<'PY'
import json
import os
import sys

with open(sys.argv[1], encoding="utf-8") as handle:
    manifest = json.load(handle)

packages = manifest["packages"]
total = sum(package.get("generatedFileCount", 0) for package in packages)
core = next(p for p in packages if p["kind"] == "core")

for package in sorted(packages, key=lambda p: -p.get("generatedFileCount", 0))[:8]:
    count = package.get("generatedFileCount", 0)
    print(f"  {package['packageId']:<40} {count:>7} ({count * 100 // max(total, 1)}%)")

print(f"  {'(total)':<40} {total:>7}")
print()

share = core.get("generatedFileCount", 0) * 100 // max(total, 1)
budget = int(os.environ.get("SPLIT_BY_TAGS_MAX_CORE_SHARE", "72"))
print(f"Core holds {share}% of the family (budget {budget}%).")

# Core is what every consumer downloads no matter which tag they wanted, so its share is the number
# this mode exists to move. A model quietly demoted back to Core -- by a new reference edge, a
# converter that can no longer be placed -- shows up here and nowhere else.
if share > budget:
    print(
        f"Core's share grew past the budget. Something stopped being splittable; find it before "
        f"raising SPLIT_BY_TAGS_MAX_CORE_SHARE.",
        file=sys.stderr,
    )
    raise SystemExit(1)
PY
