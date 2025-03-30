//HintName: G.Models.GetKnowledgeBaseSummaryFileResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetKnowledgeBaseSummaryFileResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseSummaryFileResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseSummaryFileResponseModelType value)
        {
            return value switch
            {
                GetKnowledgeBaseSummaryFileResponseModelType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseSummaryFileResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "file" => GetKnowledgeBaseSummaryFileResponseModelType.File,
                _ => null,
            };
        }
    }
}