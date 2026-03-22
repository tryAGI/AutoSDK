//HintName: G.Models.ResponseFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format type. Use 'json_schema' for structured outputs, 'json_object' for basic JSON mode, or 'text' for plain text.<br/>
    /// Default Value: text
    /// </summary>
    public enum ResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
        /// <summary>
        /// 
        /// </summary>
        Text,
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
                ResponseFormatType.JsonObject => "json_object",
                ResponseFormatType.JsonSchema => "json_schema",
                ResponseFormatType.Text => "text",
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
                "json_object" => ResponseFormatType.JsonObject,
                "json_schema" => ResponseFormatType.JsonSchema,
                "text" => ResponseFormatType.Text,
                _ => null,
            };
        }
    }
}