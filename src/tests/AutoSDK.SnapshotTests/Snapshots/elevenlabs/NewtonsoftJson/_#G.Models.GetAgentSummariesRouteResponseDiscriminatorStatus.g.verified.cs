//HintName: G.Models.GetAgentSummariesRouteResponseDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAgentSummariesRouteResponseDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
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
                GetAgentSummariesRouteResponseDiscriminatorStatus.Success => "success",
                GetAgentSummariesRouteResponseDiscriminatorStatus.Failure => "failure",
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
                "success" => GetAgentSummariesRouteResponseDiscriminatorStatus.Success,
                "failure" => GetAgentSummariesRouteResponseDiscriminatorStatus.Failure,
                _ => null,
            };
        }
    }
}