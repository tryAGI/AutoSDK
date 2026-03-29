//HintName: G.Models.GuardrailConfigInputTopic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GuardrailConfigInputTopic
    {
        /// <summary>
        /// 
        /// </summary>
        PlatformIntegrityJailbreaking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailConfigInputTopicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailConfigInputTopic value)
        {
            return value switch
            {
                GuardrailConfigInputTopic.PlatformIntegrityJailbreaking => "platform_integrity_jailbreaking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailConfigInputTopic? ToEnum(string value)
        {
            return value switch
            {
                "platform_integrity_jailbreaking" => GuardrailConfigInputTopic.PlatformIntegrityJailbreaking,
                _ => null,
            };
        }
    }
}