//HintName: G.Models.ResponseFormatTypeV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defaults to `"text"`.<br/>
    /// When set to `"json_object"`, the model's output will be a valid JSON Object.
    /// </summary>
    public enum ResponseFormatTypeV2
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
    public static class ResponseFormatTypeV2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatTypeV2 value)
        {
            return value switch
            {
                ResponseFormatTypeV2.JsonObject => "json_object",
                ResponseFormatTypeV2.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatTypeV2? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ResponseFormatTypeV2.JsonObject,
                "text" => ResponseFormatTypeV2.Text,
                _ => null,
            };
        }
    }
}