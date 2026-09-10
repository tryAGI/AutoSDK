//HintName: G.Models.AnthropicModelSettingsEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicModelSettingsEffort
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
    public static class AnthropicModelSettingsEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicModelSettingsEffort value)
        {
            return value switch
            {
                AnthropicModelSettingsEffort.High => "high",
                AnthropicModelSettingsEffort.Low => "low",
                AnthropicModelSettingsEffort.Max => "max",
                AnthropicModelSettingsEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicModelSettingsEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => AnthropicModelSettingsEffort.High,
                "low" => AnthropicModelSettingsEffort.Low,
                "max" => AnthropicModelSettingsEffort.Max,
                "medium" => AnthropicModelSettingsEffort.Medium,
                _ => null,
            };
        }
    }
}