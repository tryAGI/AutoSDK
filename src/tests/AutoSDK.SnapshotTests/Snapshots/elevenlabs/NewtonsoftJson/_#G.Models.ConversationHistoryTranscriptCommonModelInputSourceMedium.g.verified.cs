﻿//HintName: G.Models.ConversationHistoryTranscriptCommonModelInputSourceMedium.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptCommonModelInputSourceMedium
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
    public static class ConversationHistoryTranscriptCommonModelInputSourceMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptCommonModelInputSourceMedium value)
        {
            return value switch
            {
                ConversationHistoryTranscriptCommonModelInputSourceMedium.Audio => "audio",
                ConversationHistoryTranscriptCommonModelInputSourceMedium.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptCommonModelInputSourceMedium? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ConversationHistoryTranscriptCommonModelInputSourceMedium.Audio,
                "text" => ConversationHistoryTranscriptCommonModelInputSourceMedium.Text,
                _ => null,
            };
        }
    }
}