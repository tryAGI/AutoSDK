//HintName: G.Models.ResponseFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set this parameter to "json_schema" to receive structured JSON responses.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFormatType
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
    public static class ResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatType value)
        {
            return value switch
            {
                ResponseFormatType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => ResponseFormatType.JsonSchema,
                _ => null,
            };
        }
    }
}