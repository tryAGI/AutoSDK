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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coached_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CoachedAgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_base_id")]
        public string? MemoryBaseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachingAgentSettings" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: coaching
        /// </param>
        /// <param name="coachedAgentId"></param>
        /// <param name="memoryBaseId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoachingAgentSettings(
            string coachedAgentId,
            string? type,
            string? memoryBaseId)
        {
            this.CoachedAgentId = coachedAgentId ?? throw new global::System.ArgumentNullException(nameof(coachedAgentId));
            this.Type = type;
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