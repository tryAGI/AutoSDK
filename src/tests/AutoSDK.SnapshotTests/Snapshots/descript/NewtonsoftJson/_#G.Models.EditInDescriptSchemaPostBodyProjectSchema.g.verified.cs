//HintName: G.Models.EditInDescriptSchemaPostBodyProjectSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Project schema
    /// </summary>
    public sealed partial class EditInDescriptSchemaPostBodyProjectSchema
    {
        /// <summary>
        /// Schema version id.<br/>
        /// Example: 1.0.0
        /// </summary>
        /// <example>1.0.0</example>
        [global::Newtonsoft.Json.JsonProperty("schema_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string SchemaVersion { get; set; } = default!;

        /// <summary>
        /// External source id to be included in Descript export pages, see Export from Descript section for details. This ID is not currently used to deduplicate data coming into Descript, a new Project is created for each import.<br/>
        /// Example: 06b3f5bb-68a2-468a-a5d9-df155c1e3588
        /// </summary>
        /// <example>06b3f5bb-68a2-468a-a5d9-df155c1e3588</example>
        [global::Newtonsoft.Json.JsonProperty("source_id")]
        public string? SourceId { get; set; }

        /// <summary>
        /// List of remote files to import into Descript.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EditInDescriptSchemaPostBodyProjectSchemaFile> Files { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditInDescriptSchemaPostBodyProjectSchema" /> class.
        /// </summary>
        /// <param name="schemaVersion">
        /// Schema version id.<br/>
        /// Example: 1.0.0
        /// </param>
        /// <param name="files">
        /// List of remote files to import into Descript.
        /// </param>
        /// <param name="sourceId">
        /// External source id to be included in Descript export pages, see Export from Descript section for details. This ID is not currently used to deduplicate data coming into Descript, a new Project is created for each import.<br/>
        /// Example: 06b3f5bb-68a2-468a-a5d9-df155c1e3588
        /// </param>
        public EditInDescriptSchemaPostBodyProjectSchema(
            string schemaVersion,
            global::System.Collections.Generic.IList<global::G.EditInDescriptSchemaPostBodyProjectSchemaFile> files,
            string? sourceId)
        {
            this.SchemaVersion = schemaVersion ?? throw new global::System.ArgumentNullException(nameof(schemaVersion));
            this.SourceId = sourceId;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditInDescriptSchemaPostBodyProjectSchema" /> class.
        /// </summary>
        public EditInDescriptSchemaPostBodyProjectSchema()
        {
        }
    }
}