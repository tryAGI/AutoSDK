# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The $SolutionName$ SDK provides integration with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), enabling seamless interoperability with the unified .NET AI abstractions.

## Installation

```bash
dotnet add package $SolutionName$
```

## Usage

```csharp
using Microsoft.Extensions.AI;
using $SolutionName$;

using var client = new $ClientName$(
    apiKey: Environment.GetEnvironmentVariable("$SolutionNameUppercase$_API_KEY")!);

// Use with Microsoft.Extensions.AI abstractions
// See examples below for specific integration patterns
```

## Next Steps

- Check the [Examples](../index.md) for complete working code
- See the [centralized MEAI docs](https://tryagi.github.io/docs/meai/) for cross-SDK comparisons
- Visit the [Microsoft.Extensions.AI documentation](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai) for framework details
