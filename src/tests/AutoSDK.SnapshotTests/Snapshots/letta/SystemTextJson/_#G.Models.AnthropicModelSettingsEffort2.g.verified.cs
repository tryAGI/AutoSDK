//HintName: G.Models.AnthropicModelSettingsEffort2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicModelSettingsEffort2
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicModelSettingsEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicModelSettingsEffort2 value)
        {
            return value switch
            {
                AnthropicModelSettingsEffort2.High => "high",
                AnthropicModelSettingsEffort2.Low => "low",
                AnthropicModelSettingsEffort2.Max => "max",
                AnthropicModelSettingsEffort2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicModelSettingsEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => AnthropicModelSettingsEffort2.High,
                "low" => AnthropicModelSettingsEffort2.Low,
                "max" => AnthropicModelSettingsEffort2.Max,
                "medium" => AnthropicModelSettingsEffort2.Medium,
                _ => null,
            };
        }
    }
}