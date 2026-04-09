using System.Collections.Immutable;

namespace AutoSDK.Models;

public enum PollingCriterionType
{
    Simple,
    Regex,
}

public enum PollingCriterionContextType
{
    StatusCode,
    ResponseBody,
}

public record struct PollingCriterion(
    PollingCriterionType Type,
    PollingCriterionContextType ContextType,
    string JsonPointer,
    string Operator,
    string ExpectedValue,
    string Pattern)
{
    public static PollingCriterion Default => new(
        Type: PollingCriterionType.Simple,
        ContextType: PollingCriterionContextType.StatusCode,
        JsonPointer: string.Empty,
        Operator: string.Empty,
        ExpectedValue: string.Empty,
        Pattern: string.Empty);
}

public record struct PollingOperation(
    string Name,
    int DelaySeconds,
    int IntervalSeconds,
    int LimitCount,
    EquatableArray<PollingCriterion> SuccessCriteria,
    EquatableArray<PollingCriterion> FailureCriteria)
{
    public static PollingOperation Default => new(
        Name: string.Empty,
        DelaySeconds: 1,
        IntervalSeconds: 1,
        LimitCount: 60,
        SuccessCriteria: ImmutableArray<PollingCriterion>.Empty.AsEquatableArray(),
        FailureCriteria: ImmutableArray<PollingCriterion>.Empty.AsEquatableArray());
}
