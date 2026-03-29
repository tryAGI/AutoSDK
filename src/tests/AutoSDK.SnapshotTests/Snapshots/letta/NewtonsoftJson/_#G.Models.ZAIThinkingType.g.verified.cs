//HintName: G.Models.ZAIThinkingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether thinking is enabled or disabled.<br/>
    /// Default Value: enabled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ZAIThinkingType
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
    public static class ZAIThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ZAIThinkingType value)
        {
            return value switch
            {
                ZAIThinkingType.Disabled => "disabled",
                ZAIThinkingType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ZAIThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ZAIThinkingType.Disabled,
                "enabled" => ZAIThinkingType.Enabled,
                _ => null,
            };
        }
    }
}