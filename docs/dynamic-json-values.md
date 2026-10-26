# Dynamic JSON option values

Operation and tag serializer contexts register `string[]` as a supported runtime
value for object-valued dictionaries. This covers HumeAI's
`include_timestamp_types` option without using reflection or switching every child
client back to the root context. Other unregistered application types still need
an explicitly supplied serializer context.

The CLI and Roslyn aggregate context paths both register this type. An explicitly
assigned root client context continues to propagate to newly created children.

The overlapping-tag CLI regression sends actual offline POST requests containing
string arrays (including escaping and Unicode), then repeats with a user context.
It runs with reflection disabled in managed, trimmed and NativeAOT consumers.
HumeAI was regenerated with this generator in commit `8c9669e`; all four offline
`TextToSpeechClient_` tests passed, including the reported MEAI option mapping.
Its Publish workflow [40268853806](https://github.com/tryAGI/HumeAI/actions/runs/40268853806)
completed successfully.
