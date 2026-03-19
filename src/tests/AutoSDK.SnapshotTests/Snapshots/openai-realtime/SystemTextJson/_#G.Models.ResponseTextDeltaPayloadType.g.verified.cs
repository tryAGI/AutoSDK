//HintName: G.Models.ResponseTextDeltaPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseTextDeltaPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseTextDeltaPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextDeltaPayloadType value)
        {
            return value switch
            {
                ResponseTextDeltaPayloadType.ResponseTextDelta => "response.text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTextDeltaPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.text.delta" => ResponseTextDeltaPayloadType.ResponseTextDelta,
                _ => null,
            };
        }
    }
}