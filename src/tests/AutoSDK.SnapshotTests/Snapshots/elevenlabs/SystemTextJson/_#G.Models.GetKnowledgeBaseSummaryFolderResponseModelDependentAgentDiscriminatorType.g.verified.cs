//HintName: G.Models.GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType
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
    public static class GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType value)
        {
            return value switch
            {
                GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType.Available => "available",
                GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "available" => GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType.Available,
                "unknown" => GetKnowledgeBaseSummaryFolderResponseModelDependentAgentDiscriminatorType.Unknown,
                _ => null,
            };
        }
    }
}