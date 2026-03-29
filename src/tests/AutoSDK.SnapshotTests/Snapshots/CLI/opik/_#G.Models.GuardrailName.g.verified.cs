//HintName: G.Models.GuardrailName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GuardrailName
    {
        /// <summary>
        /// 
        /// </summary>
        Pii,
        /// <summary>
        /// 
        /// </summary>
        Topic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailName value)
        {
            return value switch
            {
                GuardrailName.Pii => "PII",
                GuardrailName.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailName? ToEnum(string value)
        {
            return value switch
            {
                "PII" => GuardrailName.Pii,
                "TOPIC" => GuardrailName.Topic,
                _ => null,
            };
        }
    }
}