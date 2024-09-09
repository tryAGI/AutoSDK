namespace AutoSDK.Models;

public readonly record struct Times(
    TimeSpan TraversalTree,
    TimeSpan Naming,
    TimeSpan ResolveReferences,
    TimeSpan Filtering,
    TimeSpan ComputeData,
    TimeSpan ComputeDataClasses,
    TimeSpan Total
);