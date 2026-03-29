//HintName: G.Models.VoiceSleeptimeManagerSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSleeptimeManagerSchema
    {
        /// <summary>
        /// Default Value: voice_sleeptime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ManagerAgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_message_buffer_length")]
        public int? MaxMessageBufferLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_message_buffer_length")]
        public int? MinMessageBufferLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSleeptimeManagerSchema" /> class.
        /// </summary>
        /// <param name="managerAgentId"></param>
        /// <param name="managerType">
        /// Default Value: voice_sleeptime
        /// </param>
        /// <param name="maxMessageBufferLength"></param>
        /// <param name="minMessageBufferLength"></param>
        public VoiceSleeptimeManagerSchema(
            string managerAgentId,
            string? managerType,
            int? maxMessageBufferLength,
            int? minMessageBufferLength)
        {
            this.ManagerType = managerType;
            this.ManagerAgentId = managerAgentId ?? throw new global::System.ArgumentNullException(nameof(managerAgentId));
            this.MaxMessageBufferLength = maxMessageBufferLength;
            this.MinMessageBufferLength = minMessageBufferLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSleeptimeManagerSchema" /> class.
        /// </summary>
        public VoiceSleeptimeManagerSchema()
        {
        }
    }
}