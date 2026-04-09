//HintName: G.Models.TemplatesGetTemplateSnapshotResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseAgent> Agents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blocks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseBlock> Blocks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relationships", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseRelationship> Relationships { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TemplatesGetTemplateSnapshotResponseConfiguration Configuration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseTypeJsonConverter))]
        public global::G.TemplatesGetTemplateSnapshotResponseType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponse" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="blocks"></param>
        /// <param name="relationships"></param>
        /// <param name="configuration"></param>
        /// <param name="type"></param>
        /// <param name="version"></param>
        public TemplatesGetTemplateSnapshotResponse(
            global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseAgent> agents,
            global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseBlock> blocks,
            global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseRelationship> relationships,
            global::G.TemplatesGetTemplateSnapshotResponseConfiguration configuration,
            global::G.TemplatesGetTemplateSnapshotResponseType type,
            string version)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
            this.Relationships = relationships ?? throw new global::System.ArgumentNullException(nameof(relationships));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Type = type;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponse" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponse()
        {
        }
    }
}