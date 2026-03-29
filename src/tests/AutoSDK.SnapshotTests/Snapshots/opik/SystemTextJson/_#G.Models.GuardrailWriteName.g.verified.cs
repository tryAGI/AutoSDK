//HintName: G.Models.GuardrailWriteName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GuardrailWriteName
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
    public static class GuardrailWriteNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailWriteName value)
        {
            return value switch
            {
                GuardrailWriteName.Pii => "PII",
                GuardrailWriteName.Topic => "TOPIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailWriteName? ToEnum(string value)
        {
            return value switch
            {
                "PII" => GuardrailWriteName.Pii,
                "TOPIC" => GuardrailWriteName.Topic,
                _ => null,
            };
        }
    }
}