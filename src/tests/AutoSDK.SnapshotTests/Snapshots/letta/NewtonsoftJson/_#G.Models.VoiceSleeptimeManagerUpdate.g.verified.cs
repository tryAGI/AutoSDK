//HintName: G.Models.VoiceSleeptimeManagerUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSleeptimeManagerUpdate
    {
        /// <summary>
        /// Default Value: voice_sleeptime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_agent_id")]
        public string? ManagerAgentId { get; set; }

        /// <summary>
        /// The desired maximum length of messages in the context window of the convo agent. This is a best effort, and may be off slightly due to user/assistant interleaving.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_message_buffer_length")]
        public int? MaxMessageBufferLength { get; set; }

        /// <summary>
        /// The desired minimum length of messages in the context window of the convo agent. This is a best effort, and may be off-by-one due to user/assistant interleaving.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_message_buffer_length")]
        public int? MinMessageBufferLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSleeptimeManagerUpdate" /> class.
        /// </summary>
        /// <param name="managerType">
        /// Default Value: voice_sleeptime
        /// </param>
        /// <param name="managerAgentId"></param>
        /// <param name="maxMessageBufferLength">
        /// The desired maximum length of messages in the context window of the convo agent. This is a best effort, and may be off slightly due to user/assistant interleaving.
        /// </param>
        /// <param name="minMessageBufferLength">
        /// The desired minimum length of messages in the context window of the convo agent. This is a best effort, and may be off-by-one due to user/assistant interleaving.
        /// </param>
        public VoiceSleeptimeManagerUpdate(
            string? managerType,
            string? managerAgentId,
            int? maxMessageBufferLength,
            int? minMessageBufferLength)
        {
            this.ManagerType = managerType;
            this.ManagerAgentId = managerAgentId;
            this.MaxMessageBufferLength = maxMessageBufferLength;
            this.MinMessageBufferLength = minMessageBufferLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSleeptimeManagerUpdate" /> class.
        /// </summary>
        public VoiceSleeptimeManagerUpdate()
        {
        }
    }
}