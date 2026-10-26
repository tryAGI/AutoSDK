# Runtime scalar categories and extension compatibility

`CSharpRuntimeTypeClassifier.IsRuntimeValueType` is the common contract for JSON
metadata. It classifies the emitted CLR spelling, including scalar aliases,
nullable scalar views, arrays and collection interfaces. Generated enum/union/
record types retain their existing category. Plain and referenced schemas that
emit the same CLR type therefore receive the same metadata treatment, even when
a nullable union has lost a parent schema flag or a password schema has retained
the legacy value-type flag despite emitting `string`.

Both ordinary bounded contexts and the shared-metadata planner use this contract;
the planner also normalizes immediate subtype views for nullable discovery.
Neither needs an aggregate fallback to hide a scalar inconsistency.

Three properties remain deliberately separate:

| Property | Purpose |
|---|---|
| Schema nullability / `CSharpTypeNullability` | Whether the emitted property or parameter is nullable |
| `IsRuntimeValueType()` | CLR category used to construct JSON metadata |
| Legacy `IsValueType` and computed ref/value spellings | Existing public and partial `PrepareArguments` source contract |

This change leaves the general mapper and hook emitter untouched. Replacing their
legacy flag globally would change extension signatures and must be a deliberate
versioned migration, with before/after API inventories and a downstream build
matrix. A caller's explicit JSON context continues to override defaults.

The [local downstream inventory](benchmarks/scalar-hook-inventory-20261026.json)
scanned 885 non-generated library C# files on 2026-10-26. It found five handwritten
call sites and no handwritten partial implementations in that scope. Generated
directories, `*.g.cs`, `*.Generated.cs`, build outputs and AutoSDK itself were
excluded. This does not establish compatibility for external consumers, which is
why hook signatures remain stable.

The existing shared-metadata runtime regression now exercises bool/int, a UUID
reference, date-time, password, format-only boolean and nested lists of nullable
dates through the default model context. Both managed trimmed and NativeAOT
consumers disable reflection. Date assertions compare scalar values and null
elements; this change does not alter the existing date formatting policy.
