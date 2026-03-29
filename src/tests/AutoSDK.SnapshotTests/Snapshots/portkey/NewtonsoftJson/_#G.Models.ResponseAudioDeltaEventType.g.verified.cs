//HintName: G.Models.ResponseAudioDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.audio.delta`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseAudioDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio.delta")]
        ResponseAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAudioDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAudioDeltaEventType value)
        {
            return value switch
            {
                ResponseAudioDeltaEventType.ResponseAudioDelta => "response.audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAudioDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.delta" => ResponseAudioDeltaEventType.ResponseAudioDelta,
                _ => null,
            };
        }
    }
}