//HintName: G.Models.CoachingAgentSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Runtime-only settings for the virtual coach. Not stored in the database.
    /// </summary>
    public sealed partial class CoachingAgentSettings
    {
        /// <summary>
        /// Default Value: coaching
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("coached_agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CoachedAgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory_base_id")]
        public string? MemoryBaseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachingAgentSettings" /> class.
        /// </summary>
        /// <param name="coachedAgentId"></param>
        /// <param name="type">
        /// Default Value: coaching
        /// </param>
        /// <param name="memoryBaseId"></param>
        public CoachingAgentSettings(
            string coachedAgentId,
            string? type,
            string? memoryBaseId)
        {
            this.Type = type;
            this.CoachedAgentId = coachedAgentId ?? throw new global::System.ArgumentNullException(nameof(coachedAgentId));
            this.MemoryBaseId = memoryBaseId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachingAgentSettings" /> class.
        /// </summary>
        public CoachingAgentSettings()
        {
        }
    }
}