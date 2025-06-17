//HintName: G.Models.ConversationHistoryTranscriptCommonModelOutputSourceMedium.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptCommonModelOutputSourceMedium
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
    public static class ConversationHistoryTranscriptCommonModelOutputSourceMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptCommonModelOutputSourceMedium value)
        {
            return value switch
            {
                ConversationHistoryTranscriptCommonModelOutputSourceMedium.Audio => "audio",
                ConversationHistoryTranscriptCommonModelOutputSourceMedium.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptCommonModelOutputSourceMedium? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ConversationHistoryTranscriptCommonModelOutputSourceMedium.Audio,
                "text" => ConversationHistoryTranscriptCommonModelOutputSourceMedium.Text,
                _ => null,
            };
        }
    }
}