using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

public interface IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation);
}