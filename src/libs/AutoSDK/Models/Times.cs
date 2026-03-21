namespace AutoSDK.Models;

public record struct Times(
    TimeSpan Parsing,
    TimeSpan TraversalTree,
    TimeSpan Naming,
    TimeSpan ResolveReferences,
    TimeSpan Filtering,
    TimeSpan ComputeData,
    TimeSpan ComputeDataClasses,
    TimeSpan Total,
    long AllocParsing = 0,
    long AllocTraversalTree = 0,
    long AllocNaming = 0,
    long AllocResolveReferences = 0,
    long AllocFiltering = 0,
    long AllocComputeData = 0,
    long AllocComputeDataClasses = 0,
    long AllocFilterTags = 0
);