# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build Commands
```bash
# Build solution
dotnet build
# Build specific project
dotnet build src/libs/AutoSDK/AutoSDK.csproj
```

## Test Commands
```bash
# Run all tests
dotnet test
# Run specific test project
dotnet test src/tests/AutoSDK.UnitTests/AutoSDK.UnitTests.csproj
# Run tests with filter
dotnet test --filter "FullyQualifiedName~DataTests"
```

## Code Style Guidelines
- **Naming**: PascalCase for types/methods, camelCase for parameters/variables
- **Structure**: Using directives at top, followed by namespace
- **Patterns**: Use nullable reference types, expression-bodied members, pattern matching
- **Error Handling**: Validate parameters with explicit null checks
- **Formatting**: 4 spaces indentation, braces on new lines
- **Testing**: MSTest with FluentAssertions, Verify for snapshot testing