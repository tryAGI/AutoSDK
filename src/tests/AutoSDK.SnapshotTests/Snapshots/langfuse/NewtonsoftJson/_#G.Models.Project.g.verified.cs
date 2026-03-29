//HintName: G.Models.Project.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Organization Organization { get; set; } = default!;

        /// <summary>
        /// Metadata for the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// Number of days to retain data. Null or 0 means no retention. Omitted if no retention is configured.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retentionDays")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="organization"></param>
        /// <param name="metadata">
        /// Metadata for the project
        /// </param>
        /// <param name="retentionDays">
        /// Number of days to retain data. Null or 0 means no retention. Omitted if no retention is configured.
        /// </param>
        public Project(
            string id,
            string name,
            global::G.Organization organization,
            object metadata,
            int? retentionDays)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.RetentionDays = retentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }
    }
}