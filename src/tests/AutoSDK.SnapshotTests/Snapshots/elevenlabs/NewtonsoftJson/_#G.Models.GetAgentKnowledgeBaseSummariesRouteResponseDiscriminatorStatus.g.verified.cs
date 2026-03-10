//HintName: G.Models.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus
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
    public static class GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus.Success => "success",
                GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus.Failure => "failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus.Success,
                "failure" => GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus.Failure,
                _ => null,
            };
        }
    }
}