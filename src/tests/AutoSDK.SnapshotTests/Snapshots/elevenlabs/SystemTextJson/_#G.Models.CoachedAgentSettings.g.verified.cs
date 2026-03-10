//HintName: G.Models.CoachedAgentSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CoachedAgentSettings
    {
        /// <summary>
        /// Default Value: coached
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="CoachedAgentSettings" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: coached
        /// </param>
        /// <param name="memoryBaseId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoachedAgentSettings(
            string? type,
            string? memoryBaseId)
        {
            this.Type = type;
            this.MemoryBaseId = memoryBaseId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachedAgentSettings" /> class.
        /// </summary>
        public CoachedAgentSettings()
        {
        }
    }
}