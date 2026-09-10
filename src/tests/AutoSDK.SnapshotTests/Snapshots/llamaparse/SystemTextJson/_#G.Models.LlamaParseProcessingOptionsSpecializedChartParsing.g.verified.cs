//HintName: G.Models.LlamaParseProcessingOptionsSpecializedChartParsing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlamaParseProcessingOptionsSpecializedChartParsing
    {
        /// <summary>
        /// 
        /// </summary>
        Agentic,
        /// <summary>
        /// 
        /// </summary>
        AgenticPlus,
        /// <summary>
        /// 
        /// </summary>
        Efficient,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlamaParseProcessingOptionsSpecializedChartParsingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseProcessingOptionsSpecializedChartParsing value)
        {
            return value switch
            {
                LlamaParseProcessingOptionsSpecializedChartParsing.Agentic => "agentic",
                LlamaParseProcessingOptionsSpecializedChartParsing.AgenticPlus => "agentic_plus",
                LlamaParseProcessingOptionsSpecializedChartParsing.Efficient => "efficient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseProcessingOptionsSpecializedChartParsing? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => LlamaParseProcessingOptionsSpecializedChartParsing.Agentic,
                "agentic_plus" => LlamaParseProcessingOptionsSpecializedChartParsing.AgenticPlus,
                "efficient" => LlamaParseProcessingOptionsSpecializedChartParsing.Efficient,
                _ => null,
            };
        }
    }
}