//HintName: G.Models.ResponseReasoningDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.reasoning.delta'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseReasoningDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.reasoning.delta")]
        ResponseReasoningDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningDeltaEventType value)
        {
            return value switch
            {
                ResponseReasoningDeltaEventType.ResponseReasoningDelta => "response.reasoning.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning.delta" => ResponseReasoningDeltaEventType.ResponseReasoningDelta,
                _ => null,
            };
        }
    }
}