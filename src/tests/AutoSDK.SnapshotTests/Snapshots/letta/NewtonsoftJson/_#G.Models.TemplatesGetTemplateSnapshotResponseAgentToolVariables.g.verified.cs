//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolVariables.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgentToolVariables
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolVariables" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="data"></param>
        public TemplatesGetTemplateSnapshotResponseAgentToolVariables(
            string version,
            global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem> data)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolVariables" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgentToolVariables()
        {
        }
    }
}