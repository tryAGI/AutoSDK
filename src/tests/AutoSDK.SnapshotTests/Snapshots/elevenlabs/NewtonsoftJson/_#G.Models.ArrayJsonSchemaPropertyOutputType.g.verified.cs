//HintName: G.Models.ArrayJsonSchemaPropertyOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: array
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ArrayJsonSchemaPropertyOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="array")]
        Array,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArrayJsonSchemaPropertyOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArrayJsonSchemaPropertyOutputType value)
        {
            return value switch
            {
                ArrayJsonSchemaPropertyOutputType.Array => "array",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArrayJsonSchemaPropertyOutputType? ToEnum(string value)
        {
            return value switch
            {
                "array" => ArrayJsonSchemaPropertyOutputType.Array,
                _ => null,
            };
        }
    }
}