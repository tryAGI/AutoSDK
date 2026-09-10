//HintName: G.Models.AutoModeParsingConfSpecializedChartParsing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoModeParsingConfSpecializedChartParsing
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
    public static class AutoModeParsingConfSpecializedChartParsingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoModeParsingConfSpecializedChartParsing value)
        {
            return value switch
            {
                AutoModeParsingConfSpecializedChartParsing.Agentic => "agentic",
                AutoModeParsingConfSpecializedChartParsing.AgenticPlus => "agentic_plus",
                AutoModeParsingConfSpecializedChartParsing.Efficient => "efficient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoModeParsingConfSpecializedChartParsing? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => AutoModeParsingConfSpecializedChartParsing.Agentic,
                "agentic_plus" => AutoModeParsingConfSpecializedChartParsing.AgenticPlus,
                "efficient" => AutoModeParsingConfSpecializedChartParsing.Efficient,
                _ => null,
            };
        }
    }
}