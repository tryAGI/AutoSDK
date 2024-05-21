using Microsoft.OpenApi.Models;

namespace OpenApiGenerator.Core.Naming.Methods;

public interface IMethodNameGenerator
{
    public string? TryGenerate(OpenApiOperation operation, string path, OperationType operationType);
}