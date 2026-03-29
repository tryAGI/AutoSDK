//HintName: G.Models.AgentRequestWebhookEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentRequestWebhookEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call_analyzed")]
        CallAnalyzed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call_ended")]
        CallEnded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call_started")]
        CallStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript_updated")]
        TranscriptUpdated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_bridged")]
        TransferBridged,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_cancelled")]
        TransferCancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_ended")]
        TransferEnded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_started")]
        TransferStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestWebhookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestWebhookEvent value)
        {
            return value switch
            {
                AgentRequestWebhookEvent.CallAnalyzed => "call_analyzed",
                AgentRequestWebhookEvent.CallEnded => "call_ended",
                AgentRequestWebhookEvent.CallStarted => "call_started",
                AgentRequestWebhookEvent.TranscriptUpdated => "transcript_updated",
                AgentRequestWebhookEvent.TransferBridged => "transfer_bridged",
                AgentRequestWebhookEvent.TransferCancelled => "transfer_cancelled",
                AgentRequestWebhookEvent.TransferEnded => "transfer_ended",
                AgentRequestWebhookEvent.TransferStarted => "transfer_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestWebhookEvent? ToEnum(string value)
        {
            return value switch
            {
                "call_analyzed" => AgentRequestWebhookEvent.CallAnalyzed,
                "call_ended" => AgentRequestWebhookEvent.CallEnded,
                "call_started" => AgentRequestWebhookEvent.CallStarted,
                "transcript_updated" => AgentRequestWebhookEvent.TranscriptUpdated,
                "transfer_bridged" => AgentRequestWebhookEvent.TransferBridged,
                "transfer_cancelled" => AgentRequestWebhookEvent.TransferCancelled,
                "transfer_ended" => AgentRequestWebhookEvent.TransferEnded,
                "transfer_started" => AgentRequestWebhookEvent.TransferStarted,
                _ => null,
            };
        }
    }
}