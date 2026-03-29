//HintName: G.Models.CreateChatCompletionRequestThinkingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enables or disables the thinking mode capability.<br/>
    /// Default Value: disabled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestThinkingType
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
    public static class CreateChatCompletionRequestThinkingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestThinkingType value)
        {
            return value switch
            {
                CreateChatCompletionRequestThinkingType.Disabled => "disabled",
                CreateChatCompletionRequestThinkingType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestThinkingType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CreateChatCompletionRequestThinkingType.Disabled,
                "enabled" => CreateChatCompletionRequestThinkingType.Enabled,
                _ => null,
            };
        }
    }
}