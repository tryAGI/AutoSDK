//HintName: G.Models.ConversationHistoryTranscriptCommonModelInputSourceMedium2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptCommonModelInputSourceMedium2
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
    public static class ConversationHistoryTranscriptCommonModelInputSourceMedium2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptCommonModelInputSourceMedium2 value)
        {
            return value switch
            {
                ConversationHistoryTranscriptCommonModelInputSourceMedium2.Audio => "audio",
                ConversationHistoryTranscriptCommonModelInputSourceMedium2.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptCommonModelInputSourceMedium2? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ConversationHistoryTranscriptCommonModelInputSourceMedium2.Audio,
                "text" => ConversationHistoryTranscriptCommonModelInputSourceMedium2.Text,
                _ => null,
            };
        }
    }
}