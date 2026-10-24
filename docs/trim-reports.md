# Trimming compatibility reports and symbol policy

`autosdk trim` can report physical publication sizes without counting debug information as executable SDK code:

```bash
autosdk trim src/libs/MySdk/MySdk.csproj --report-json artifacts/trim.json
autosdk trim src/libs/MySdk/MySdk.csproj --remove-symbols --report-json artifacts/trim-without-managed-symbols.json
autosdk trim src/libs/MySdk/MySdk.csproj --aot --report-json artifacts/nativeaot.json
```

The default remains managed trimming with the .NET SDK's inherited symbol policy. `--aot` opts into an actual NativeAOT publication; it requires the target platform's native toolchain and can take substantially longer. `--remove-symbols` passes `TrimmerRemoveSymbols=true` to publication. It removes managed symbols during linking, reducing source/debug information. It does not request removal of native debug artifacts such as `.dbg` or `.dSYM`; those are reported separately. No package or global debug settings are changed.

This command roots the complete target assembly to validate compatibility. The JSON `rooting` field states that explicitly. **These measurements are not unused-endpoint trimming acceptance.** To measure pruning, publish an application that calls the desired typed/MEAI endpoints from a precompiled NuGet package without a root-all context, execute its runtime contracts, and inspect which unrelated model/factory families remain.

The report has `schemaVersion: 1` and records:

| Field | Meaning |
|---|---|
| `publishMode` | `trim` or `nativeaot` |
| `symbolPolicy` | `inherit` or explicit `remove-managed` |
| `publishSeconds`, `publishExitCode`, `trimmingWarningCount` | Actual publication outcome; failed publication is not reported as successful compatibility |
| `publishDirectoryBytes` | All files in the publication, including runtime and debug artifacts |
| `externalSymbolBytes` | Separate `.pdb`, `.dbg`, and files inside `.dSYM` directories |
| `appExecutableBytes` | The generated check application's executable; in managed mode this is its apphost, in NativeAOT mode it contains compiled application code |
| `assemblies` | Managed published DLL metrics, without loading those DLLs into the process |

Each managed assembly has physical file bytes, compressed on-disk embedded Portable PDB bytes, the PE remainder excluding that PDB payload, metadata bytes, IL body bytes, and type/method/field counts. The remainder includes headers, resources and padding: it must not be labeled pure code. Metadata/IL sizes are subsets, not extra bytes to add to the file total. Embedded PDB bytes are already inside DLL file bytes; external debug files are inside the directory total. Native libraries are not misclassified as managed metadata.

Choose a JSON path outside the temporary validation directory. The report survives cleanup; each invocation uses an isolated temporary child directory and removes only its own files. No warnings are suppressed to obtain a smaller report.

A measured package-consumer comparison is available in [the 2026-10-24 report](trimming-measurements-20261024.md#embedded-symbol-experiment). Its Anthropic helper DLL changes from 3,245,056 bytes to 86,528 bytes when removing symbols, while metadata/IL counts and runtime behavior remain identical. [Issue #451](https://github.com/tryAGI/AutoSDK/issues/451) tracks this reporting change.
