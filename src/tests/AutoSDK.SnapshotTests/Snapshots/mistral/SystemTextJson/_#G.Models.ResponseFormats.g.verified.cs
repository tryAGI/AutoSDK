//HintName: G.Models.ResponseFormats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object specifying the format that the model must output. Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is in JSON. When using JSON mode you MUST also instruct the model to produce JSON yourself with a system or a user message.
    /// </summary>
    public enum ResponseFormats
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// "json_object" }` enables JSON mode, which guarantees the message the model generates is in JSON. When using JSON mode you MUST also instruct the model to produce JSON yourself with a system or a user message.
        /// </summary>
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormats value)
        {
            return value switch
            {
                ResponseFormats.Text => "text",
                ResponseFormats.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormats? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponseFormats.Text,
                "json_object" => ResponseFormats.JsonObject,
                _ => null,
            };
        }
    }
}