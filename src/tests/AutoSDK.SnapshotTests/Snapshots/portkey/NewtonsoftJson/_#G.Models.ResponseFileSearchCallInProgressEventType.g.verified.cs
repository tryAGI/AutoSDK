//HintName: G.Models.ResponseFileSearchCallInProgressEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.file_search_call.in_progress`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFileSearchCallInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.file_search_call.in_progress")]
        ResponseFileSearchCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFileSearchCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFileSearchCallInProgressEventType value)
        {
            return value switch
            {
                ResponseFileSearchCallInProgressEventType.ResponseFileSearchCallInProgress => "response.file_search_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFileSearchCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.file_search_call.in_progress" => ResponseFileSearchCallInProgressEventType.ResponseFileSearchCallInProgress,
                _ => null,
            };
        }
    }
}