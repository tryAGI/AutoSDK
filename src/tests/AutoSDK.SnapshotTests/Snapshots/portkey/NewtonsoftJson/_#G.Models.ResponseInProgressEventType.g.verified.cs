//HintName: G.Models.ResponseInProgressEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.in_progress`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.in_progress")]
        ResponseInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInProgressEventType value)
        {
            return value switch
            {
                ResponseInProgressEventType.ResponseInProgress => "response.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.in_progress" => ResponseInProgressEventType.ResponseInProgress,
                _ => null,
            };
        }
    }
}