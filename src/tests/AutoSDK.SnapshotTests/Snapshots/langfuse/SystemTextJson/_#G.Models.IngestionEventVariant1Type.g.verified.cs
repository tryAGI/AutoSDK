//HintName: G.Models.IngestionEventVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IngestionEventVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        TraceCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventVariant1Type value)
        {
            return value switch
            {
                IngestionEventVariant1Type.TraceCreate => "trace-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "trace-create" => IngestionEventVariant1Type.TraceCreate,
                _ => null,
            };
        }
    }
}