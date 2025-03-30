//HintName: G.Models.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Available,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType value)
        {
            return value switch
            {
                GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType.Available => "available",
                GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType.Available,
                "unknown" => GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}