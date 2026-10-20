; Unshipped analyzer release

### New Rules

Rule ID | Category | Severity | Notes
--------|----------|----------|-------
AMETA001 | AutoSDK.JsonMetadata | Error | Reject unsupported shared metadata inputs or changes in the pinned STJ factory shape.
AMETA002 | AutoSDK.JsonMetadata | Warning | Preserve nested STJ warnings and their original ID/location without duplicating ordinary-context diagnostics.
AMETA003 | AutoSDK.JsonMetadata | Error | Reject unsupported shared metadata manifest protocol versions before running STJ.
