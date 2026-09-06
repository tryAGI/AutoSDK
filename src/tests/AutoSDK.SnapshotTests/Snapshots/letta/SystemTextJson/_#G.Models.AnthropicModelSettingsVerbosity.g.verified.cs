//HintName: G.Models.AnthropicModelSettingsVerbosity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicModelSettingsVerbosity
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
    public static class AnthropicModelSettingsVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicModelSettingsVerbosity value)
        {
            return value switch
            {
                AnthropicModelSettingsVerbosity.High => "high",
                AnthropicModelSettingsVerbosity.Low => "low",
                AnthropicModelSettingsVerbosity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicModelSettingsVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => AnthropicModelSettingsVerbosity.High,
                "low" => AnthropicModelSettingsVerbosity.Low,
                "medium" => AnthropicModelSettingsVerbosity.Medium,
                _ => null,
            };
        }
    }
}