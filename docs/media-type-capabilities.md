# Media type capabilities

AutoSDK representation planners use this matrix to select only wire formats the generated client can encode or decode faithfully.

| Media types | Request | Response | Notes |
| --- | --- | --- | --- |
| application/json, text/json, application/*+json | Typed | Typed | Typed JSON serialization and deserialization; equivalent vendor JSON types are deduplicated. |
| multipart/form-data | Typed | Unsupported | Typed request parts, including repeated and binary file parts. |
| application/x-www-form-urlencoded | Typed | Unsupported | Typed request properties are emitted as form fields. |
| application/octet-stream, application/zip, application/pdf, image/*, audio/*, video/*, font/* | Raw | Raw | Raw string or byte-array request transport and byte-array responses; response stream companions are generated. |
| text/* except text/event-stream and text/json | Raw | Raw | Raw string request and response transport. |
| application/x-ndjson, application/jsonl, application/json-seq | Typed | Streaming | Typed newline-delimited or record-separated JSON. |
| text/event-stream | Unsupported | Streaming | Typed server-sent event response stream. |
| application/vnd.amazon.eventstream | Unsupported | Streaming | AWS event-stream response framing. |
| application/msgpack, application/x-msgpack | Raw | Raw | Raw byte pass-through only; typed MessagePack codecs are not generated. |
| application/protobuf, application/x-protobuf, application/vnd.google.protobuf | Raw | Raw | Raw byte pass-through only; typed protobuf codecs are not generated. |
| Other vendor-specific media types | Raw | Raw | Raw string or byte-array pass-through only; typed provider-specific codecs are not generated. |

Raw request support requires a matching string or binary schema. MessagePack, protobuf, and provider-specific typed codecs are intentionally not synthesized; use raw text/bytes or add a JSON/form representation.
