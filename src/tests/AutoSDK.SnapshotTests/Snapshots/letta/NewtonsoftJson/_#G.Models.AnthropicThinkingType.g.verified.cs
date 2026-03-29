//HintName: G.Models.AnthropicThinkingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of thinking to use.<br/>
    /// Default Value: enabled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnthropicThinkingType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkingType value)
        {
            return value switch
            {
                AnthropicThinkingType.Disabled => "disabled",
                AnthropicThinkingType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AnthropicThinkingType.Disabled,
                "enabled" => AnthropicThinkingType.Enabled,
                _ => null,
            };
        }
    }
}