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
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseAgent> Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseBlock> Blocks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseRelationship> Relationships { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TemplatesGetTemplateSnapshotResponseConfiguration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TemplatesGetTemplateSnapshotResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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