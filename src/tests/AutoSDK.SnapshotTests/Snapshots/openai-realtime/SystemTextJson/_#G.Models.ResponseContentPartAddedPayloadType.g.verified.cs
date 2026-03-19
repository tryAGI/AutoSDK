//HintName: G.Models.ResponseContentPartAddedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseContentPartAddedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseContentPartAddedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseContentPartAddedPayloadType value)
        {
            return value switch
            {
                ResponseContentPartAddedPayloadType.ResponseContentPartAdded => "response.content_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseContentPartAddedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.added" => ResponseContentPartAddedPayloadType.ResponseContentPartAdded,
                _ => null,
            };
        }
    }
}