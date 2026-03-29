//HintName: G.Models.ResponseCompletedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.completed")]
        ResponseCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCompletedEventType value)
        {
            return value switch
            {
                ResponseCompletedEventType.ResponseCompleted => "response.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.completed" => ResponseCompletedEventType.ResponseCompleted,
                _ => null,
            };
        }
    }
}