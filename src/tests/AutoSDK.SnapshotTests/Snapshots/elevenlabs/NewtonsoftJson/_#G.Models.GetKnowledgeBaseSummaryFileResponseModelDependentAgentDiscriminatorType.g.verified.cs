//HintName: G.Models.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="available")]
        Available,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType value)
        {
            return value switch
            {
                GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType.Available => "available",
                GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType.Available,
                "unknown" => GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}