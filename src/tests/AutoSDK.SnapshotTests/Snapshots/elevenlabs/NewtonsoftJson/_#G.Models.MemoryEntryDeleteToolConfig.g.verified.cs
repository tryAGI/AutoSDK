//HintName: G.Models.MemoryEntryDeleteToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryEntryDeleteToolConfig
    {
        /// <summary>
        /// Default Value: memory_entry_delete
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryEntryDeleteToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: memory_entry_delete
        /// </param>
        public MemoryEntryDeleteToolConfig(
            string? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryEntryDeleteToolConfig" /> class.
        /// </summary>
        public MemoryEntryDeleteToolConfig()
        {
        }
    }
}