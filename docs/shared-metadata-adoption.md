# Coordinated shared JSON metadata adoption

Shared metadata remains an explicit profile for validated monolithic net10.0 SDKs.
Legacy targets and split packages keep their existing path. Independent generated
contexts are not automatically selected as a large-SDK fallback.

The scaffold couples `--shared-json-metadata`, the generated version-binding props
and an `AutoSDK.JsonMetadata` PackageReference with `PrivateAssets="all"`.
Its update script passes `--shared-json-metadata-project` and uses stale-file cleanup
instead of deleting Generated before validation. The CLI validates the consuming
project before writing anything; normal invocations also discover a project in
the output directory or beside it. Multiple projects require an explicit selection.
Standalone output without a consuming project emits the binding and explicit
project/analyzer setup instructions; it does not scaffold a consuming project.
Existing shared artifacts or an analyzer reference also reject regeneration
without the shared flag, preventing silent profile drift. A deliberate switch
requires removing the shared setup and choosing fresh output.
The guard checks the literal net10.0 target, matching binding import and private,
version-bound analyzer reference. Projects with custom imported setup must expose
these properties directly before using this profile.

Run the read-only fleet audit with:

```sh
python3 scripts/audit-shared-json-metadata.py --workspace ..
python3 scripts/audit-shared-json-metadata.py SDK.csproj --expected-cli-version 0.35.0-preview.2.134 --package SDK.nupkg
```

The audit checks generation flags, supported targets, manifest protocols, exact
analyzer bindings and private assets. Package checks reject build-only dependency
IDs and AutoSDK/Roslyn generator DLLs hidden in `lib/` or `runtimes/`; a legitimate
analyzer in `analyzers/` is not a runtime asset.

The [2026-10-26 inventory](benchmarks/shared-metadata-adoption-20261026.json)
examined 262 library projects and found four enabled SDKs with valid setup and no
audit errors: OpenAI (analyzer `.123`), Anthropic and ElevenLabs (`.131`), and
AppStoreConnect (`.134`), all in the `0.35.0-preview.2` series. Exact repository
commits and full versions are recorded. This inventory reads local sources and
does not claim every checkout is synchronized or every published package audited.

The measured migration batches are documented in
[the Anthropic/ElevenLabs report](trimming-measurements-20261024.md),
[OpenAI's consumer report](https://github.com/tryAGI/OpenAI/blob/main/docs/trimming-measurements-20261024.md)
and [AppStoreConnect's final validation](stable-anonymous-union-names.md).
They distinguish SDK source compilation CPU/memory and full DLL/package size from
warm precompiled NuGet consumer publications, root/leaf retention and runtime
contracts. Preserve their pinned versions and limitations when comparing results.
The default for existing SDKs is unchanged; another batch needs the same evidence
before adoption, including package dependency auditing and hand-written API checks.
