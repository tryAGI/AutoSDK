# Binary and structured success outcomes

An operation can return audio immediately (`200 audio/wav` or `200 audio/ogg`)
or queue work (`202 application/json`). The server chooses the outcome at runtime;
requesting a media type does not guarantee that outcome.

For multiple successful statuses with a binary branch and a different body contract,
AutoSDK generates one operation returning a nested, status-discriminated result:

```csharp
using var result = await client.StreamOrQueueAsync(cancellationToken: cancellationToken);
switch (result.StatusCode)
{
    case HttpStatusCode.OK:
        await result.Body200!.CopyToAsync(destination, cancellationToken);
        break;
    case HttpStatusCode.Accepted:
        Console.WriteLine(result.Body202!.Id);
        break;
}
```

`Body200` is a `Stream`; `Body202` is the generated queued-job model. Inactive
body properties are null. Equivalent media types for a status share a body property.
If one status has different body contracts, the properties also have a `Variant`
suffix. The result preserves status, response and content headers, and request URI.
`AsResponseAsync` also returns the same result in its `Body` property.

Each call sends one request unless the caller explicitly enables retries. Decoding
uses the actual status and Content-Type, ignoring parameter suffixes such as
`charset=utf-8` and matching media types without case sensitivity. A successful
status/media pair outside the declared contracts fails with `ApiException` rather
than decoding binary bytes as JSON. Existing typed non-success error handling
continues to apply.

Binary bodies stay unbuffered and retain ownership of the HTTP response. Dispose
the result (or its binary stream) after reading. Structured bodies are read and
decoded before return, and their HTTP response is released immediately. Cancellation
is passed to body reads; when reading the returned stream, pass the cancellation
token to the stream operation as well. Read/decode failures release the response.

Single-success operations and equivalent binary success contracts keep their
existing byte-array and stream methods. This change does not combine SSE, NDJSON,
or AWS event streams with other outcomes, and does not change JSON-only operations.

## Issue #453 baseline

The synthetic fixture is `specs/heterogeneous-success.yaml`; it needs no credentials
or provider calls.

- Original issue baseline: CLI `0.35.0-preview.2.75`, source
  `64f6747d92cf5abf1db543dfb63e1ec67880466e` (generation/signature inspection).
- Rechecked before implementation on October 25, 2026: CLI
  `0.35.0-preview.2.134+ad2a95d111c611fa513e94f18d47c708e97b6714`, matching the
  latest published version in NuGet's AutoSDK.CLI version index.
- The newer baseline emitted `StreamOrQueueAsync` returning the JSON model and
  a separate `StreamOrQueueAsBytesAsync` (with a stream companion). Each path still
  assumed one fixed body type, so the alternate runtime status remained unsafe.
- The fix emits `StreamOrQueueAsync` and `StreamOrQueueAsResponseAsync` returning
  the typed result; it does not multiply response-media methods.

`CliHeterogeneousSuccessTests` generates and compiles a real client and executes it
against a fake HTTP handler. It covers WAV/Ogg, exact non-UTF8 bytes, queued JSON,
metadata, normal and wrapped results, cancellation during JSON and binary reads,
HTTP errors, mismatched Content-Type, disposal, and one request per outcome.
Source-generator snapshots cover both System.Text.Json and Newtonsoft.Json with
empty compiler diagnostics. Unit tests cover contract selection and equivalent
binary-response compatibility.

```sh
dotnet test src/tests/AutoSDK.UnitTests --filter FullyQualifiedName~HeterogeneousSuccessTests
dotnet test src/tests/AutoSDK.SnapshotTests --filter FullyQualifiedName~HeterogeneousSuccess
dotnet test src/tests/AutoSDK.IntegrationTests.Cli --filter FullyQualifiedName~CliHeterogeneousSuccessTests
```

## Local validation

- Generator build: .NET Framework 4.6.2, .NET Standard 2.0, and .NET 10; zero warnings/errors.
- Unit tests: 716 passed, zero skipped.
- SDK source-generator snapshots: 245 passed, including both serializers for this fixture.
  The two fixture snapshots were rechecked after the final metadata handling refinement.
- Focused CLI integration tests: three passed, including the compiled fake-HTTP runtime regression.

These checks use synthetic HTTP responses; they do not claim provider or downstream SDK acceptance.
