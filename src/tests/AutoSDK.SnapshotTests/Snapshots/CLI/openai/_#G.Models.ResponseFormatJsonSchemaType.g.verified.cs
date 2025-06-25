﻿//HintName: G.Models.ResponseFormatJsonSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of response format being defined. Always `json_schema`.
    /// </summary>
    public enum ResponseFormatJsonSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatJsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatJsonSchemaType value)
        {
            return value switch
            {
                ResponseFormatJsonSchemaType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatJsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => ResponseFormatJsonSchemaType.JsonSchema,
                _ => null,
            };
        }
    }
}