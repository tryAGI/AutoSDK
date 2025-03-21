//HintName: G.Models.ResponseAudioDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.audio.done`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseAudioDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.audio.done")]
        ResponseAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAudioDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAudioDoneEventType value)
        {
            return value switch
            {
                ResponseAudioDoneEventType.ResponseAudioDone => "response.audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAudioDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.done" => ResponseAudioDoneEventType.ResponseAudioDone,
                _ => null,
            };
        }
    }
}