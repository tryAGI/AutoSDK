//HintName: G.Models.ArrayJsonSchemaPropertyInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: array
    /// </summary>
    public enum ArrayJsonSchemaPropertyInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArrayJsonSchemaPropertyInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArrayJsonSchemaPropertyInputType value)
        {
            return value switch
            {
                ArrayJsonSchemaPropertyInputType.Array => "array",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArrayJsonSchemaPropertyInputType? ToEnum(string value)
        {
            return value switch
            {
                "array" => ArrayJsonSchemaPropertyInputType.Array,
                _ => null,
            };
        }
    }
}