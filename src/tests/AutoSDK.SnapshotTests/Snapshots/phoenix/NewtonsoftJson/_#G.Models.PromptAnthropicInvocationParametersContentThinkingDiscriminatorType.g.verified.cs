//HintName: G.Models.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptAnthropicInvocationParametersContentThinkingDiscriminatorType
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
    public static class PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAnthropicInvocationParametersContentThinkingDiscriminatorType value)
        {
            return value switch
            {
                PromptAnthropicInvocationParametersContentThinkingDiscriminatorType.Disabled => "disabled",
                PromptAnthropicInvocationParametersContentThinkingDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAnthropicInvocationParametersContentThinkingDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => PromptAnthropicInvocationParametersContentThinkingDiscriminatorType.Disabled,
                "enabled" => PromptAnthropicInvocationParametersContentThinkingDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}