//HintName: G.Models.GetKnowledgeBaseSummaryURLResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseSummaryURLResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseSummaryURLResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseSummaryURLResponseModelType value)
        {
            return value switch
            {
                GetKnowledgeBaseSummaryURLResponseModelType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseSummaryURLResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "url" => GetKnowledgeBaseSummaryURLResponseModelType.Url,
                _ => null,
            };
        }
    }
}