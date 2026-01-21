//HintName: G.Models.ResponseFormatV2DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFormatV2DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatV2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatV2DiscriminatorType value)
        {
            return value switch
            {
                ResponseFormatV2DiscriminatorType.Text => "text",
                ResponseFormatV2DiscriminatorType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatV2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponseFormatV2DiscriminatorType.Text,
                "json_object" => ResponseFormatV2DiscriminatorType.JsonObject,
                _ => null,
            };
        }
    }
}