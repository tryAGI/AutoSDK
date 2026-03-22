//HintName: G.Models.GetAgentSummariesRouteResponseDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentSummariesRouteResponseDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentSummariesRouteResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentSummariesRouteResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetAgentSummariesRouteResponseDiscriminatorStatus.Failure => "failure",
                GetAgentSummariesRouteResponseDiscriminatorStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentSummariesRouteResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => GetAgentSummariesRouteResponseDiscriminatorStatus.Failure,
                "success" => GetAgentSummariesRouteResponseDiscriminatorStatus.Success,
                _ => null,
            };
        }
    }
}