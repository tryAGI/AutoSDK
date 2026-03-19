//HintName: G.Models.ResponseAudioDeltaPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseAudioDeltaPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAudioDeltaPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAudioDeltaPayloadType value)
        {
            return value switch
            {
                ResponseAudioDeltaPayloadType.ResponseAudioDelta => "response.audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAudioDeltaPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.delta" => ResponseAudioDeltaPayloadType.ResponseAudioDelta,
                _ => null,
            };
        }
    }
}