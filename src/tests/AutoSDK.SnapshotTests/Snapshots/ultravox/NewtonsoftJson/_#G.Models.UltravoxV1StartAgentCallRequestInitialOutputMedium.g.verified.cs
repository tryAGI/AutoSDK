//HintName: G.Models.UltravoxV1StartAgentCallRequestInitialOutputMedium.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The (overridden) medium initially used by the agent. May be altered by the client later.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UltravoxV1StartAgentCallRequestInitialOutputMedium
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_MEDIUM_TEXT")]
        MessageMediumText,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1StartAgentCallRequestInitialOutputMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1StartAgentCallRequestInitialOutputMedium value)
        {
            return value switch
            {
                UltravoxV1StartAgentCallRequestInitialOutputMedium.MessageMediumText => "MESSAGE_MEDIUM_TEXT",
                UltravoxV1StartAgentCallRequestInitialOutputMedium.MessageMediumUnspecified => "MESSAGE_MEDIUM_UNSPECIFIED",
                UltravoxV1StartAgentCallRequestInitialOutputMedium.MessageMediumVoice => "MESSAGE_MEDIUM_VOICE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1StartAgentCallRequestInitialOutputMedium? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_MEDIUM_TEXT" => UltravoxV1StartAgentCallRequestInitialOutputMedium.MessageMediumText,
                "MESSAGE_MEDIUM_UNSPECIFIED" => UltravoxV1StartAgentCallRequestInitialOutputMedium.MessageMediumUnspecified,
                "MESSAGE_MEDIUM_VOICE" => UltravoxV1StartAgentCallRequestInitialOutputMedium.MessageMediumVoice,
                _ => null,
            };
        }
    }
}