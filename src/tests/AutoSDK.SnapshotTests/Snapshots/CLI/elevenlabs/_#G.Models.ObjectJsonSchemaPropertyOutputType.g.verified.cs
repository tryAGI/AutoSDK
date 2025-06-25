//HintName: G.Models.ObjectJsonSchemaPropertyOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: object
    /// </summary>
    public enum ObjectJsonSchemaPropertyOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectJsonSchemaPropertyOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectJsonSchemaPropertyOutputType value)
        {
            return value switch
            {
                ObjectJsonSchemaPropertyOutputType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectJsonSchemaPropertyOutputType? ToEnum(string value)
        {
            return value switch
            {
                "object" => ObjectJsonSchemaPropertyOutputType.Object,
                _ => null,
            };
        }
    }
}