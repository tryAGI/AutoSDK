using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Naming.Methods;

public interface IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation);
}