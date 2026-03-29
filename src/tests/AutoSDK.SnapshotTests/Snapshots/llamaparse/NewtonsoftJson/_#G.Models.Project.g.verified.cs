//HintName: G.Models.Project.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for a project.
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Unique identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Creation datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Update datetime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ad_hoc_eval_dataset_id")]
        public global::System.Guid? AdHocEvalDatasetId { get; set; }

        /// <summary>
        /// The Organization ID the project is under.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrganizationId { get; set; } = default!;

        /// <summary>
        /// Whether this project is the default project for the user.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id">
        /// Unique identifier
        /// </param>
        /// <param name="organizationId">
        /// The Organization ID the project is under.
        /// </param>
        /// <param name="createdAt">
        /// Creation datetime
        /// </param>
        /// <param name="updatedAt">
        /// Update datetime
        /// </param>
        /// <param name="adHocEvalDatasetId"></param>
        /// <param name="isDefault">
        /// Whether this project is the default project for the user.<br/>
        /// Default Value: false
        /// </param>
        public Project(
            string name,
            global::System.Guid id,
            global::System.Guid organizationId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Guid? adHocEvalDatasetId,
            bool? isDefault)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AdHocEvalDatasetId = adHocEvalDatasetId;
            this.OrganizationId = organizationId;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }
    }
}