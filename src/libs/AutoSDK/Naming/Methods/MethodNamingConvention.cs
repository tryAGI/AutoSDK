using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

public enum MethodNamingConvention
{
    SimpleOperationId,
    MethodAndPath,
    OperationIdWithDots,
    OperationIdSplit,
}

public static class MethodNamingConventionExtensions
{
    public static IMethodNameGenerator GetGenerator(this MethodNamingConvention operation)
    {
        return operation switch
        {
            MethodNamingConvention.SimpleOperationId => new SimpleOperationIdGenerator(),
            MethodNamingConvention.OperationIdWithDots => new OperationIdWithDotsGenerator(),
            MethodNamingConvention.MethodAndPath => new MethodAndPathGenerator(),
            MethodNamingConvention.OperationIdSplit => new OperationIdSplitGenerator(),
            _ => throw new ArgumentOutOfRangeException(nameof(operation), operation, null),
        };
    }

    public static string GetMethodName(this OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));
        
        var mainGenerator = operation.Settings.MethodNamingConvention.GetGenerator();
        var fallbackGenerator = operation.Settings.MethodNamingConventionFallback.GetGenerator();
        
        return mainGenerator.TryGenerate(operation) ??
               fallbackGenerator.TryGenerate(operation) ??
               throw new InvalidOperationException("Failed to generate method name");
    }
}