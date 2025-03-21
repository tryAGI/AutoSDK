//HintName: G.Models.ResponseTextDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.output_text.delta`.
    /// </summary>
    public enum ResponseTextDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextDeltaEventType value)
        {
            return value switch
            {
                ResponseTextDeltaEventType.ResponseOutputTextDelta => "response.output_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.delta" => ResponseTextDeltaEventType.ResponseOutputTextDelta,
                _ => null,
            };
        }
    }
}