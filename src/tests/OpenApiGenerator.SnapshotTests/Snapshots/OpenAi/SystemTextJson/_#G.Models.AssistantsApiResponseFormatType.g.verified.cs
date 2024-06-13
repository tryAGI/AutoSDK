//HintName: G.Models.AssistantsApiResponseFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be one of `text` or `json_object`.<br/>
    /// Default Value: text<br/>
    /// Example: json_object
    /// </summary>
    public enum AssistantsApiResponseFormatType
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
    public static class AssistantsApiResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantsApiResponseFormatType value)
        {
            return value switch
            {
                AssistantsApiResponseFormatType.Text => "text",
                AssistantsApiResponseFormatType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantsApiResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AssistantsApiResponseFormatType.Text,
                "json_object" => AssistantsApiResponseFormatType.JsonObject,
                _ => null,
            };
        }
    }
}