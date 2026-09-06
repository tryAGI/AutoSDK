//HintName: G.Models.AutoModeParsingConfSpecializedChartParsing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutoModeParsingConfSpecializedChartParsing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agentic")]
        Agentic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agentic_plus")]
        AgenticPlus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="efficient")]
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