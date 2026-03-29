//HintName: G.Models.SummarizationConfigSummaryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SummarizationConfigSummaryType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bullets")]
        Bullets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="paragraphs")]
        Paragraphs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizationConfigSummaryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizationConfigSummaryType value)
        {
            return value switch
            {
                SummarizationConfigSummaryType.Bullets => "bullets",
                SummarizationConfigSummaryType.Paragraphs => "paragraphs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizationConfigSummaryType? ToEnum(string value)
        {
            return value switch
            {
                "bullets" => SummarizationConfigSummaryType.Bullets,
                "paragraphs" => SummarizationConfigSummaryType.Paragraphs,
                _ => null,
            };
        }
    }
}