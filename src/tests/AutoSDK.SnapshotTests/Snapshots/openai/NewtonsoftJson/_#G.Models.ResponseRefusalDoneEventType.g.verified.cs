//HintName: G.Models.ResponseRefusalDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.refusal.done`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseRefusalDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.refusal.done")]
        ResponseRefusalDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRefusalDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRefusalDoneEventType value)
        {
            return value switch
            {
                ResponseRefusalDoneEventType.ResponseRefusalDone => "response.refusal.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRefusalDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.refusal.done" => ResponseRefusalDoneEventType.ResponseRefusalDone,
                _ => null,
            };
        }
    }
}