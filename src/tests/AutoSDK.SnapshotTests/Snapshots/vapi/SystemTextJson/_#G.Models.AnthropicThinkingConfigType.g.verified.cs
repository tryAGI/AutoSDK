//HintName: G.Models.AnthropicThinkingConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicThinkingConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkingConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkingConfigType value)
        {
            return value switch
            {
                AnthropicThinkingConfigType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkingConfigType? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => AnthropicThinkingConfigType.Enabled,
                _ => null,
            };
        }
    }
}