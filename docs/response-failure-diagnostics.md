# Response processing diagnostics (#436)

For a successful HTTP status followed by a processing failure, generated
`ApiException.Message` now starts with the HTTP status and inner exception type
and message. JSON paths are included for System.Text.Json and Newtonsoft.Json.
The cause and response preview are bounded to 512 characters each; paths are
bounded to 256. A logger retaining only the first 1 KiB therefore keeps the
underlying metadata/deserialization cause before a large image/base64 response.

The exception hierarchy, status, `InnerException`, `ResponseBody` and headers
remain available. HTTP service-error messages retain their previous format.
Successful-response processing includes deserialization, response hooks and
response-stream acquisition failures; the diagnostic does not mislabel those as
HTTP service rejections. Existing stream failures still use the documented
best-effort body capture; string-buffered responses preserve the complete body.

Migration: code parsing a successful-response exception's `Message` as JSON must
use `ResponseBody` instead. No generated method signatures or exception types
change. Full response bodies are never discarded merely to shorten diagnostics.

Validation compiles the emitted exception types and exercises a 100,012-character
response with the typed hierarchy enabled/disabled, both JSON serializers, JSON
paths, original inner-exception identity, full body/status preservation and
unchanged HTTP 404 messages/types. The runtime regression failed before the fix
because the primary message contained all 100,012 characters.
