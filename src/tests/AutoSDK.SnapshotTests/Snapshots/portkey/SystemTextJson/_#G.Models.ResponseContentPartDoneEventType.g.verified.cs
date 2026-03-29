//HintName: G.Models.ResponseContentPartDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.content_part.done`.
    /// </summary>
    public enum ResponseContentPartDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseContentPartDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseContentPartDoneEventType value)
        {
            return value switch
            {
                ResponseContentPartDoneEventType.ResponseContentPartDone => "response.content_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseContentPartDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.done" => ResponseContentPartDoneEventType.ResponseContentPartDone,
                _ => null,
            };
        }
    }
}