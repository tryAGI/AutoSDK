//HintName: G.Models.AutoModeParsingConfSpecializedChartParsing2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutoModeParsingConfSpecializedChartParsing2
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
    public static class AutoModeParsingConfSpecializedChartParsing2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoModeParsingConfSpecializedChartParsing2 value)
        {
            return value switch
            {
                AutoModeParsingConfSpecializedChartParsing2.Agentic => "agentic",
                AutoModeParsingConfSpecializedChartParsing2.AgenticPlus => "agentic_plus",
                AutoModeParsingConfSpecializedChartParsing2.Efficient => "efficient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoModeParsingConfSpecializedChartParsing2? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => AutoModeParsingConfSpecializedChartParsing2.Agentic,
                "agentic_plus" => AutoModeParsingConfSpecializedChartParsing2.AgenticPlus,
                "efficient" => AutoModeParsingConfSpecializedChartParsing2.Efficient,
                _ => null,
            };
        }
    }
}