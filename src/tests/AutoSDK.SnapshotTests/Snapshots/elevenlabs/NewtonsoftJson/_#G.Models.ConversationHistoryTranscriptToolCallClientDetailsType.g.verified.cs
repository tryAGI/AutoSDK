//HintName: G.Models.ConversationHistoryTranscriptToolCallClientDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: client
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptToolCallClientDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="client")]
        Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptToolCallClientDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptToolCallClientDetailsType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptToolCallClientDetailsType.Client => "client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptToolCallClientDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationHistoryTranscriptToolCallClientDetailsType.Client,
                _ => null,
            };
        }
    }
}