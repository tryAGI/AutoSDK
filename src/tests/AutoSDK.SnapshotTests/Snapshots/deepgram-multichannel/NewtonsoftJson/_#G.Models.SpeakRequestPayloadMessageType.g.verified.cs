//HintName: G.Models.SpeakRequestPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeakRequestPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speak_request")]
        SpeakRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakRequestPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakRequestPayloadMessageType value)
        {
            return value switch
            {
                SpeakRequestPayloadMessageType.SpeakRequest => "speak_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakRequestPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "speak_request" => SpeakRequestPayloadMessageType.SpeakRequest,
                _ => null,
            };
        }
    }
}