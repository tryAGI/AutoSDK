//HintName: G.Models.NoCoachingSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NoCoachingSettings
    {
        /// <summary>
        /// Default Value: none
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="NoCoachingSettings" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: none
        /// </param>
        /// <param name="memoryBaseId"></param>
        public NoCoachingSettings(
            string? type,
            string? memoryBaseId)
        {
            this.Type = type;
            this.MemoryBaseId = memoryBaseId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoCoachingSettings" /> class.
        /// </summary>
        public NoCoachingSettings()
        {
        }
    }
}