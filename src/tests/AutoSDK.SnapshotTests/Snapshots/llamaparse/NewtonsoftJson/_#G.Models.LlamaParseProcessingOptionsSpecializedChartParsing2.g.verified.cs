//HintName: G.Models.LlamaParseProcessingOptionsSpecializedChartParsing2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LlamaParseProcessingOptionsSpecializedChartParsing2
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
    public static class LlamaParseProcessingOptionsSpecializedChartParsing2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseProcessingOptionsSpecializedChartParsing2 value)
        {
            return value switch
            {
                LlamaParseProcessingOptionsSpecializedChartParsing2.Agentic => "agentic",
                LlamaParseProcessingOptionsSpecializedChartParsing2.AgenticPlus => "agentic_plus",
                LlamaParseProcessingOptionsSpecializedChartParsing2.Efficient => "efficient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseProcessingOptionsSpecializedChartParsing2? ToEnum(string value)
        {
            return value switch
            {
                "agentic" => LlamaParseProcessingOptionsSpecializedChartParsing2.Agentic,
                "agentic_plus" => LlamaParseProcessingOptionsSpecializedChartParsing2.AgenticPlus,
                "efficient" => LlamaParseProcessingOptionsSpecializedChartParsing2.Efficient,
                _ => null,
            };
        }
    }
}