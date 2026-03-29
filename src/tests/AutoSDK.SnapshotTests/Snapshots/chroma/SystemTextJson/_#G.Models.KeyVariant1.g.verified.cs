//HintName: G.Models.KeyVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum KeyVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyVariant1 value)
        {
            return value switch
            {
                KeyVariant1.Document => "Document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyVariant1? ToEnum(string value)
        {
            return value switch
            {
                "Document" => KeyVariant1.Document,
                _ => null,
            };
        }
    }
}