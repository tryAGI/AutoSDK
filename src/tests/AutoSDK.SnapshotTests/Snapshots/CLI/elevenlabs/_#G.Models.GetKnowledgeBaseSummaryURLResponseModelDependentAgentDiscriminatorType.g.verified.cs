//HintName: G.Models.GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType
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
    public static class GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType value)
        {
            return value switch
            {
                GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType.Available => "available",
                GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType.Available,
                "unknown" => GetKnowledgeBaseSummaryURLResponseModelDependentAgentDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}