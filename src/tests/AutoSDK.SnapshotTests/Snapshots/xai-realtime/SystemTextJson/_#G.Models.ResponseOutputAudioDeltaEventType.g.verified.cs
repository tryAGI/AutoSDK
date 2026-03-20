//HintName: G.Models.ResponseOutputAudioDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOutputAudioDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputAudioDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputAudioDeltaEventType value)
        {
            return value switch
            {
                ResponseOutputAudioDeltaEventType.ResponseOutputAudioDelta => "response.output_audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputAudioDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio.delta" => ResponseOutputAudioDeltaEventType.ResponseOutputAudioDelta,
                _ => null,
            };
        }
    }
}