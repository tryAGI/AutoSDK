//HintName: G.Models.ResponseRefusalDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.refusal.delta`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseRefusalDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.refusal.delta")]
        ResponseRefusalDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRefusalDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRefusalDeltaEventType value)
        {
            return value switch
            {
                ResponseRefusalDeltaEventType.ResponseRefusalDelta => "response.refusal.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRefusalDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.refusal.delta" => ResponseRefusalDeltaEventType.ResponseRefusalDelta,
                _ => null,
            };
        }
    }
}