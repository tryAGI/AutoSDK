//HintName: G.Models.ThinkingConfigThinkingLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. Controls the maximum depth of the model's internal reasoning process before it produces a response. If not specified, the default is HIGH. Recommended for Gemini 3 or later models. Use with earlier models results in an error.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ThinkingConfigThinkingLevel
    {
        /// <summary>
        /// High thinking level.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HIGH")]
        High,
        /// <summary>
        /// Low thinking level.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LOW")]
        Low,
        /// <summary>
        /// Medium thinking level.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEDIUM")]
        Medium,
        /// <summary>
        /// Little to no thinking.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MINIMAL")]
        Minimal,
        /// <summary>
        /// Default value.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="THINKING_LEVEL_UNSPECIFIED")]
        ThinkingLevelUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingConfigThinkingLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingConfigThinkingLevel value)
        {
            return value switch
            {
                ThinkingConfigThinkingLevel.High => "HIGH",
                ThinkingConfigThinkingLevel.Low => "LOW",
                ThinkingConfigThinkingLevel.Medium => "MEDIUM",
                ThinkingConfigThinkingLevel.Minimal => "MINIMAL",
                ThinkingConfigThinkingLevel.ThinkingLevelUnspecified => "THINKING_LEVEL_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingConfigThinkingLevel? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => ThinkingConfigThinkingLevel.High,
                "LOW" => ThinkingConfigThinkingLevel.Low,
                "MEDIUM" => ThinkingConfigThinkingLevel.Medium,
                "MINIMAL" => ThinkingConfigThinkingLevel.Minimal,
                "THINKING_LEVEL_UNSPECIFIED" => ThinkingConfigThinkingLevel.ThinkingLevelUnspecified,
                _ => null,
            };
        }
    }
}