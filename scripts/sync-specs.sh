#!/usr/bin/env bash
# sync-specs.sh — Copy OpenAPI specs from sibling SDK repos into AutoSDK/specs/
#
# Usage:
#   ./scripts/sync-specs.sh                    # default: looks for repos in ../
#   ./scripts/sync-specs.sh /path/to/tryAGI    # explicit parent directory
#
# Naming convention:
#   SDK repo name → lowercase, dots→hyphens, original extension preserved
#   e.g., Google.Gemini/openapi.json → google-gemini-discovery.json
#
# When a spec already exists with a different extension (format change),
# the script updates the EXISTING file to preserve test references.

set -uo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
AUTOSDK_ROOT="$(cd "$SCRIPT_DIR/.." && pwd)"
SPECS_DIR="$AUTOSDK_ROOT/specs"
REPOS_DIR="${1:-$(cd "$AUTOSDK_ROOT/.." && pwd)}"

# SDK repos that should be skipped entirely (not SDKs or have custom spec handling)
SKIP_REPOS="AutoSDK AutoSDK.Portal docs LangChain LangChain.Providers LangChain.Databases LangChain.Maui LangChainChat CSharpToJsonSchema DotnetCliWrapper SdkTemplate Tiktoken openai-dotnet AI askmycv PrivateJoi Transcendence Do"

# Specs that are hand-maintained or test-only (never overwrite)
SKIP_DEST="additional-properties-collision.yaml circular-refs.yaml deepgram-const-discriminator.json deepgram-inline-payloads.json deepgram-multichannel.json elevenlabs-realtime-stt.json elevenlabs-realtime-stt-xref.json filtering.yaml github.yaml google-gemini.yaml ipinfo.yaml mystic.yaml ollama-official.yaml openai-realtime.json petstore.yaml security.yaml special-cases.yaml stream-variants.yaml xai-realtime.json"

# Custom naming overrides: "SDK_NAME:dest_basename" (without extension)
# Used when the default lowercase→hyphen rule doesn't match existing specs
OVERRIDES="Google.Gemini:google-gemini-discovery"

# SDKs whose spec extension changed but we want to keep the old filename
# Format: "SDK_NAME:existing_filename" — the SDK's spec will overwrite this file
FORMAT_OVERRIDES="HuggingFace:huggingface.yaml Ideogram:ideogram.yaml Leonardo:leonardo.yaml Replicate:replicate.json Runway:runway.yaml Weaviate:weaviate.yaml"

# SDKs with custom-named test specs (skip the main openapi spec)
# Their specs are in AutoSDK/specs under different names (e.g., deepgram-multichannel.json)
SKIP_SDKS="Deepgram Xai"

is_in_list() {
    echo "$2" | grep -qw "$1"
}

get_override_name() {
    local sdk="$1"
    for entry in $OVERRIDES; do
        local key="${entry%%:*}"
        local val="${entry#*:}"
        if [[ "$key" == "$sdk" ]]; then
            echo "$val"
            return 0
        fi
    done
    return 1
}

get_format_override() {
    local sdk="$1"
    for entry in $FORMAT_OVERRIDES; do
        local key="${entry%%:*}"
        local val="${entry#*:}"
        if [[ "$key" == "$sdk" ]]; then
            echo "$val"
            return 0
        fi
    done
    return 1
}

to_spec_name() {
    local sdk_dir="$1"
    local override
    if override=$(get_override_name "$sdk_dir"); then
        echo "$override"
        return
    fi
    echo "$sdk_dir" | tr '[:upper:]' '[:lower:]' | tr '.' '-'
}

copied=0
skipped=0
unchanged=0

echo "Syncing specs from $REPOS_DIR → $SPECS_DIR"
echo ""

for sdk_path in "$REPOS_DIR"/*/; do
    sdk_name="$(basename "$sdk_path")"

    # Skip non-SDK directories
    if is_in_list "$sdk_name" "$SKIP_REPOS"; then
        continue
    fi

    # Skip SDKs with custom-named test specs
    if is_in_list "$sdk_name" "$SKIP_SDKS"; then
        skipped=$((skipped + 1))
        continue
    fi

    # Look for openapi spec in standard location
    spec_base="$sdk_path/src/libs/$sdk_name"
    src_file=""
    ext=""

    if [[ -f "$spec_base/openapi.yaml" ]]; then
        src_file="$spec_base/openapi.yaml"
        ext="yaml"
    elif [[ -f "$spec_base/openapi.json" ]]; then
        src_file="$spec_base/openapi.json"
        ext="json"
    else
        continue
    fi

    # Check for format override (SDK changed format but we keep old filename)
    local_dest=""
    if local_dest=$(get_format_override "$sdk_name"); then
        dest_name="$local_dest"
    else
        dest_name="$(to_spec_name "$sdk_name").$ext"
    fi

    if is_in_list "$dest_name" "$SKIP_DEST"; then
        skipped=$((skipped + 1))
        continue
    fi

    dest_file="$SPECS_DIR/$dest_name"

    if [[ -f "$dest_file" ]] && diff -q "$src_file" "$dest_file" >/dev/null 2>&1; then
        unchanged=$((unchanged + 1))
        continue
    fi

    cp "$src_file" "$dest_file"
    echo "  Updated: $dest_name (from $sdk_name)"
    copied=$((copied + 1))
done

echo ""
echo "Done: $copied copied/updated, $unchanged unchanged, $skipped skipped"
echo "Total specs: $(ls "$SPECS_DIR" | wc -l | tr -d ' ')"
