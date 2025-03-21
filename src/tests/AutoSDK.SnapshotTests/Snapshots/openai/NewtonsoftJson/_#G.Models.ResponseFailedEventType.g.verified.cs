//HintName: G.Models.ResponseFailedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.failed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFailedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.failed")]
        ResponseFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFailedEventType value)
        {
            return value switch
            {
                ResponseFailedEventType.ResponseFailed => "response.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.failed" => ResponseFailedEventType.ResponseFailed,
                _ => null,
            };
        }
    }
}