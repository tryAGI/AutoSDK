//HintName: G.Models.PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChannelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_name")]
        public string? ChannelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_message_ts")]
        public string? LastMessageTs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel" /> class.
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="channelName"></param>
        /// <param name="lastMessageTs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel(
            string channelId,
            string? channelName,
            string? lastMessageTs)
        {
            this.ChannelId = channelId ?? throw new global::System.ArgumentNullException(nameof(channelId));
            this.ChannelName = channelName;
            this.LastMessageTs = lastMessageTs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel" /> class.
        /// </summary>
        public PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel()
        {
        }
    }
}