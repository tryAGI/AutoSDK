//HintName: G.Models.UltravoxV1StartCallRequestInitialOutputMedium.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The medium to use for the call initially. May be altered by the client later.<br/>
    ///  Defaults to voice.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UltravoxV1StartCallRequestInitialOutputMedium
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_MEDIUM_UNSPECIFIED")]
        MessageMediumUnspecified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_MEDIUM_VOICE")]
        MessageMediumVoice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_MEDIUM_TEXT")]
        MessageMediumText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1StartCallRequestInitialOutputMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1StartCallRequestInitialOutputMedium value)
        {
            return value switch
            {
                UltravoxV1StartCallRequestInitialOutputMedium.MessageMediumUnspecified => "MESSAGE_MEDIUM_UNSPECIFIED",
                UltravoxV1StartCallRequestInitialOutputMedium.MessageMediumVoice => "MESSAGE_MEDIUM_VOICE",
                UltravoxV1StartCallRequestInitialOutputMedium.MessageMediumText => "MESSAGE_MEDIUM_TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1StartCallRequestInitialOutputMedium? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_MEDIUM_UNSPECIFIED" => UltravoxV1StartCallRequestInitialOutputMedium.MessageMediumUnspecified,
                "MESSAGE_MEDIUM_VOICE" => UltravoxV1StartCallRequestInitialOutputMedium.MessageMediumVoice,
                "MESSAGE_MEDIUM_TEXT" => UltravoxV1StartCallRequestInitialOutputMedium.MessageMediumText,
                _ => null,
            };
        }
    }
}