//HintName: G.Models.ResponseOutputAudioDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOutputAudioDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputAudioDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputAudioDoneEventType value)
        {
            return value switch
            {
                ResponseOutputAudioDoneEventType.ResponseOutputAudioDone => "response.output_audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputAudioDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio.done" => ResponseOutputAudioDoneEventType.ResponseOutputAudioDone,
                _ => null,
            };
        }
    }
}