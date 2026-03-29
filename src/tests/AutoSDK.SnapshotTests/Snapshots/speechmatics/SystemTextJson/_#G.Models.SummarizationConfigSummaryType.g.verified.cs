//HintName: G.Models.SummarizationConfigSummaryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SummarizationConfigSummaryType
    {
        /// <summary>
        /// 
        /// </summary>
        Bullets,
        /// <summary>
        /// 
        /// </summary>
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