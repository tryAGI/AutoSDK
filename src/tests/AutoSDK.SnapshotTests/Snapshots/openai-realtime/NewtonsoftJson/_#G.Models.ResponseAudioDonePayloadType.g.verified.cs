//HintName: G.Models.ResponseAudioDonePayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseAudioDonePayloadType
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
    public static class ResponseAudioDonePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAudioDonePayloadType value)
        {
            return value switch
            {
                ResponseAudioDonePayloadType.ResponseAudioDone => "response.audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAudioDonePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.done" => ResponseAudioDonePayloadType.ResponseAudioDone,
                _ => null,
            };
        }
    }
}