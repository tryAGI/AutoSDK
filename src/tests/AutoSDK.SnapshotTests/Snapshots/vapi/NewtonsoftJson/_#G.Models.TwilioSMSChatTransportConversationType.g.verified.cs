//HintName: G.Models.TwilioSMSChatTransportConversationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).<br/>
    /// Default Value: chat
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TwilioSMSChatTransportConversationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioSMSChatTransportConversationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioSMSChatTransportConversationType value)
        {
            return value switch
            {
                TwilioSMSChatTransportConversationType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioSMSChatTransportConversationType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => TwilioSMSChatTransportConversationType.Chat,
                _ => null,
            };
        }
    }
}