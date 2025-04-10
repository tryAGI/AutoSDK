//HintName: G.Models.SchemaRetrieveFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SchemaRetrieveFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Yaml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemaRetrieveFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaRetrieveFormat value)
        {
            return value switch
            {
                SchemaRetrieveFormat.Json => "json",
                SchemaRetrieveFormat.Yaml => "yaml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaRetrieveFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => SchemaRetrieveFormat.Json,
                "yaml" => SchemaRetrieveFormat.Yaml,
                _ => null,
            };
        }
    }
}