//HintName: G.Models.UltravoxV1StartCallRequestFirstSpeaker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Who should talk first when the call starts. Typically set to FIRST_SPEAKER_USER for outgoing<br/>
    ///  calls and left as the default (FIRST_SPEAKER_AGENT) otherwise.<br/>
    ///  Deprecated. Prefer `firstSpeakerSettings`. If both are set, they must match.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UltravoxV1StartCallRequestFirstSpeaker
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_SPEAKER_UNSPECIFIED")]
        FIRSTSPEAKERUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_SPEAKER_AGENT")]
        FIRSTSPEAKERAGENT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_SPEAKER_USER")]
        FIRSTSPEAKERUSER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1StartCallRequestFirstSpeakerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1StartCallRequestFirstSpeaker value)
        {
            return value switch
            {
                UltravoxV1StartCallRequestFirstSpeaker.FIRSTSPEAKERUNSPECIFIED => "FIRST_SPEAKER_UNSPECIFIED",
                UltravoxV1StartCallRequestFirstSpeaker.FIRSTSPEAKERAGENT => "FIRST_SPEAKER_AGENT",
                UltravoxV1StartCallRequestFirstSpeaker.FIRSTSPEAKERUSER => "FIRST_SPEAKER_USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1StartCallRequestFirstSpeaker? ToEnum(string value)
        {
            return value switch
            {
                "FIRST_SPEAKER_UNSPECIFIED" => UltravoxV1StartCallRequestFirstSpeaker.FIRSTSPEAKERUNSPECIFIED,
                "FIRST_SPEAKER_AGENT" => UltravoxV1StartCallRequestFirstSpeaker.FIRSTSPEAKERAGENT,
                "FIRST_SPEAKER_USER" => UltravoxV1StartCallRequestFirstSpeaker.FIRSTSPEAKERUSER,
                _ => null,
            };
        }
    }
}