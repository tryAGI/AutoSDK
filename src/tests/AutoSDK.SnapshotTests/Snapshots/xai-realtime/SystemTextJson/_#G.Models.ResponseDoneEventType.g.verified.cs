//HintName: G.Models.ResponseDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDoneEventType value)
        {
            return value switch
            {
                ResponseDoneEventType.ResponseDone => "response.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.done" => ResponseDoneEventType.ResponseDone,
                _ => null,
            };
        }
    }
}