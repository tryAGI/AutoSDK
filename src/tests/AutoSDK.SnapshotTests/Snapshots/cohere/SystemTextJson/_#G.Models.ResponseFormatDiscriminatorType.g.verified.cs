//HintName: G.Models.ResponseFormatDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFormatDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatDiscriminatorType value)
        {
            return value switch
            {
                ResponseFormatDiscriminatorType.JsonObject => "json_object",
                ResponseFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ResponseFormatDiscriminatorType.JsonObject,
                "text" => ResponseFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}