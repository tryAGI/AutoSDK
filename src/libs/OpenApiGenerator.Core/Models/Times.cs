namespace OpenApiGenerator.Core.Models;

public readonly record struct Times(
    TimeSpan TraversalTree,
    TimeSpan ResolveCollisions,
    TimeSpan ResolveReferences,
    TimeSpan Filtering,
    TimeSpan ComputeData,
    TimeSpan ComputeDataClasses,
    TimeSpan Total
);