# Generated C# null-forgiving inventory (issue #406)

The baseline is the 2026-09-28 `AdvantageClient/Generated` tree from Advantage main. A Roslyn syntax walk counted `PostfixUnaryExpressionSyntax` nodes with `SyntaxKind.SuppressNullableWarningExpression` in the generated C# tree. This distinguishes nullable suppression from logical negation, inequality, and exclamation marks in strings. The baseline contains **9,477** sites.

| Generated family | Baseline sites | Generator source and disposition |
| --- | ---: | --- |
| Operation methods | 6,050 | `Sources.Methods.cs` `HookInvocation.AppendTo` emitted `__httpRequest!`. Hook context creation now checks the request explicitly. The request is assigned once per attempt before the before hook and remains undisposed through the success, error, and retry hooks. |
| Operation methods | 614 | `Sources.Methods.cs` `GeneratePrepareRequestParameterArgument` suppressed nonnullable path and other parameter arguments. The generated method signature already carries the nullable contract; the suppression is removed. |
| Operation methods | 10 | `ParameterSerializer.AppendSerializedQueryParameter` emitted `ToString()!` for required query values. The generated expression now checks for a null result. Required parameters whose schemas allow null still flow through the optional path builder without a throw. |
| Named union models | 2,136 | `Sources.Models.AnyOf.cs` emitted `!` for `Pick`, `Match`, and `Switch`. A property pattern now captures the nonnull variant and preserves the null branch. |
| Anonymous AllOf models | 104 | Same union template and replacement as named models. |
| Union JSON converters | 560 | `Sources.JsonConverters.AnyOf.cs` used `value.Variant!` after testing `IsVariant`. The converter now calls `PickVariant()`, which checks and returns the active variant. |
| Conditional request support | 1 | `Sources.HttpResponse.cs` suppressed `entityTag!` after `IsNullOrWhiteSpace`. A property pattern now gives the guarded nonnull value a local name. |
| Hook context support | 2 | `Sources.OptionsSupport.cs` now emits nullable `Request` and `ClientOptions` properties. `CreateHookContext` fills both in its object initializer before returning the context to a hook. A caller may still construct a partial context; the authorization hook skips one without a request, while the cloud signing hook reports a missing request explicitly. This removes the two suppressions without requiring C# `required` members or changing object-initializer construction. |

The categories above account for all 9,477 baseline sites. The prior local regeneration from Advantage's OpenAPI input produced **2** sites, both in `Advantage.OptionsSupport.g.cs`. A fresh regeneration from the committed OpenAPI input now produces 9,976 C# files with no `null!` expressions. The corresponding `Advantage.OptionsSupport.g.cs` was committed in Advantage after its client build passed, bringing the checked-in generated tree to zero known suppression sites. The generator change does not alter OpenAPI schemas, JSON member names, or wire serialization; it corrects the hook-context properties' nullable annotations to reflect partially constructed contexts.

An additional repository-wide source scan found two sites outside that Advantage inventory: the optional prompt-template cache output and the generator's numeric-validation parser selector. Both now use nullable outputs with explicit checks, so the C# generator source itself contains no `null!` expressions.
