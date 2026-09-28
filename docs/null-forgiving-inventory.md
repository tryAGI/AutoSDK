# Generated C# null-forgiving inventory (issue #406)

The baseline is the 2026-09-28 `AdvantageClient/Generated` tree from Advantage main. A Roslyn syntax walk counted `PostfixUnaryExpressionSyntax` nodes with `SyntaxKind.SuppressNullableWarningExpression` in the 1,201 generated C# files. This distinguishes nullable suppression from logical negation, inequality, and exclamation marks in strings. The baseline contains **9,477** sites.

| Generated family | Baseline sites | Generator source and disposition |
| --- | ---: | --- |
| Operation methods | 6,050 | `Sources.Methods.cs` `HookInvocation.AppendTo` emitted `__httpRequest!`. Hook context creation now checks the request explicitly. The request is assigned once per attempt before the before hook and remains undisposed through the success, error, and retry hooks. |
| Operation methods | 614 | `Sources.Methods.cs` `GeneratePrepareRequestParameterArgument` suppressed nonnullable path and other parameter arguments. The generated method signature already carries the nullable contract; the suppression is removed. |
| Operation methods | 10 | `ParameterSerializer.AppendSerializedQueryParameter` emitted `ToString()!` for required query values. The generated expression now checks for a null result. Required parameters whose schemas allow null still flow through the optional path builder without a throw. |
| Named union models | 2,136 | `Sources.Models.AnyOf.cs` emitted `!` for `Pick`, `Match`, and `Switch`. A property pattern now captures the nonnull variant and preserves the null branch. |
| Anonymous AllOf models | 104 | Same union template and replacement as named models. |
| Union JSON converters | 560 | `Sources.JsonConverters.AnyOf.cs` used `value.Variant!` after testing `IsVariant`. The converter now calls `PickVariant()`, which checks and returns the active variant. |
| Conditional request support | 1 | `Sources.HttpResponse.cs` suppressed `entityTag!` after `IsNullOrWhiteSpace`. A property pattern now gives the guarded nonnull value a local name. |
| Hook context support | 2 | `Sources.OptionsSupport.cs` initializes public, settable `Request` and `ClientOptions` to `null!`. `CreateHookContext` fills both in its object initializer before returning the context to a hook. These two sites remain because the generated public type supports construction with an object initializer across target frameworks, including frameworks without `required` members. Callers constructing a context themselves must set both properties before using it. |

The categories above account for all 9,477 baseline sites. A local regeneration from Advantage's OpenAPI input with this generator produced **2** sites, both in `Advantage.OptionsSupport.g.cs`, as counted by the same Roslyn syntax walk. The published-tool regeneration and build in Advantage remain the acceptance checks for its repository. The generator change does not alter OpenAPI schemas, nullable method signatures, JSON member names, or wire serialization.
