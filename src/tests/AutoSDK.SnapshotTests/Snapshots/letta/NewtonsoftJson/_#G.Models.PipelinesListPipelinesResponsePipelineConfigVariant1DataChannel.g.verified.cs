//HintName: G.Models.PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChannelId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_name")]
        public string? ChannelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_message_ts")]
        public string? LastMessageTs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel" /> class.
        /// </summary>
        /// <param name="channelId"></param>
        /// <param name="channelName"></param>
        /// <param name="lastMessageTs"></param>
        public PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel(
            string channelId,
            string? channelName,
            string? lastMessageTs)
        {
            this.ChannelId = channelId ?? throw new global::System.ArgumentNullException(nameof(channelId));
            this.ChannelName = channelName;
            this.LastMessageTs = lastMessageTs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel" /> class.
        /// </summary>
        public PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel()
        {
        }
    }
}