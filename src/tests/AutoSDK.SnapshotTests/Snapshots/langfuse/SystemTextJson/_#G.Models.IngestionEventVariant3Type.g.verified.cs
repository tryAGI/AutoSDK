//HintName: G.Models.IngestionEventVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IngestionEventVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        SpanCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventVariant3Type value)
        {
            return value switch
            {
                IngestionEventVariant3Type.SpanCreate => "span-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "span-create" => IngestionEventVariant3Type.SpanCreate,
                _ => null,
            };
        }
    }
}