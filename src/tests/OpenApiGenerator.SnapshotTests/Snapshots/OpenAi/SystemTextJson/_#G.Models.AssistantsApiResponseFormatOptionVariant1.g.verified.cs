//HintName: G.Models.AssistantsApiResponseFormatOptionVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    public enum AssistantsApiResponseFormatOptionVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantsApiResponseFormatOptionVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantsApiResponseFormatOptionVariant1 value)
        {
            return value switch
            {
                AssistantsApiResponseFormatOptionVariant1.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantsApiResponseFormatOptionVariant1? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AssistantsApiResponseFormatOptionVariant1.Auto,
                _ => null,
            };
        }
    }
}