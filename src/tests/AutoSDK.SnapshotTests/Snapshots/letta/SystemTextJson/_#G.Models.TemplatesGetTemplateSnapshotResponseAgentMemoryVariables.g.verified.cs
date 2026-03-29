//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentMemoryVariables.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgentMemoryVariables
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseAgentMemoryVariablesDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentMemoryVariables" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesGetTemplateSnapshotResponseAgentMemoryVariables(
            string version,
            global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseAgentMemoryVariablesDataItem> data)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentMemoryVariables" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgentMemoryVariables()
        {
        }
    }
}