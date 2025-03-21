//HintName: G.Models.ResponseContentPartAddedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.content_part.added`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseContentPartAddedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.content_part.added")]
        ResponseContentPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseContentPartAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseContentPartAddedEventType value)
        {
            return value switch
            {
                ResponseContentPartAddedEventType.ResponseContentPartAdded => "response.content_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseContentPartAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.added" => ResponseContentPartAddedEventType.ResponseContentPartAdded,
                _ => null,
            };
        }
    }
}