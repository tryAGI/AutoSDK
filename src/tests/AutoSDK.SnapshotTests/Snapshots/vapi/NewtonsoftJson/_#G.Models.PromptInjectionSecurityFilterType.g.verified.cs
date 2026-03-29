//HintName: G.Models.PromptInjectionSecurityFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of security threat to filter.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptInjectionSecurityFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt-injection")]
        PromptInjection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptInjectionSecurityFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptInjectionSecurityFilterType value)
        {
            return value switch
            {
                PromptInjectionSecurityFilterType.PromptInjection => "prompt-injection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptInjectionSecurityFilterType? ToEnum(string value)
        {
            return value switch
            {
                "prompt-injection" => PromptInjectionSecurityFilterType.PromptInjection,
                _ => null,
            };
        }
    }
}