//HintName: G.Models.ConversationHistoryTranscriptCommonModelOutputSourceMedium2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptCommonModelOutputSourceMedium2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptCommonModelOutputSourceMedium2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptCommonModelOutputSourceMedium2 value)
        {
            return value switch
            {
                ConversationHistoryTranscriptCommonModelOutputSourceMedium2.Audio => "audio",
                ConversationHistoryTranscriptCommonModelOutputSourceMedium2.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptCommonModelOutputSourceMedium2? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ConversationHistoryTranscriptCommonModelOutputSourceMedium2.Audio,
                "text" => ConversationHistoryTranscriptCommonModelOutputSourceMedium2.Text,
                _ => null,
            };
        }
    }
}