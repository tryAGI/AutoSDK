//HintName: G.Models.ResponseFormatNullishJsonSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFormatNullishJsonSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json_schema")]
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatNullishJsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatNullishJsonSchemaType value)
        {
            return value switch
            {
                ResponseFormatNullishJsonSchemaType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatNullishJsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => ResponseFormatNullishJsonSchemaType.JsonSchema,
                _ => null,
            };
        }
    }
}