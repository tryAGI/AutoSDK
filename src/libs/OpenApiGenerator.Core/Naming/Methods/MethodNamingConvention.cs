namespace OpenApiGenerator.Core.Naming.Methods;

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
}