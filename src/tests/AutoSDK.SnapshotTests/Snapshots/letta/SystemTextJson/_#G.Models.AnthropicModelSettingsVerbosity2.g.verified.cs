//HintName: G.Models.AnthropicModelSettingsVerbosity2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicModelSettingsVerbosity2
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
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicModelSettingsVerbosity2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicModelSettingsVerbosity2 value)
        {
            return value switch
            {
                AnthropicModelSettingsVerbosity2.High => "high",
                AnthropicModelSettingsVerbosity2.Low => "low",
                AnthropicModelSettingsVerbosity2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicModelSettingsVerbosity2? ToEnum(string value)
        {
            return value switch
            {
                "high" => AnthropicModelSettingsVerbosity2.High,
                "low" => AnthropicModelSettingsVerbosity2.Low,
                "medium" => AnthropicModelSettingsVerbosity2.Medium,
                _ => null,
            };
        }
    }
}