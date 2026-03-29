//HintName: G.Models.Label.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Label
    {
        /// <summary>
        /// Unique identifier for the label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Name of the label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Color code for the label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color_code")]
        public string? ColorCode { get; set; }

        /// <summary>
        /// ID of the organisation the label belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// ID of the workspace the label belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Whether the label is universal
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_universal")]
        public bool? IsUniversal { get; set; }

        /// <summary>
        /// When the label was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the label was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Status of the label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the label
        /// </param>
        /// <param name="name">
        /// Name of the label
        /// </param>
        /// <param name="description">
        /// Description of the label
        /// </param>
        /// <param name="colorCode">
        /// Color code for the label
        /// </param>
        /// <param name="organisationId">
        /// ID of the organisation the label belongs to
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace the label belongs to
        /// </param>
        /// <param name="isUniversal">
        /// Whether the label is universal
        /// </param>
        /// <param name="createdAt">
        /// When the label was created
        /// </param>
        /// <param name="lastUpdatedAt">
        /// When the label was last updated
        /// </param>
        /// <param name="status">
        /// Status of the label
        /// </param>
        public Label(
            global::System.Guid? id,
            string? name,
            string? description,
            string? colorCode,
            global::System.Guid? organisationId,
            global::System.Guid? workspaceId,
            bool? isUniversal,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            string? status)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ColorCode = colorCode;
            this.OrganisationId = organisationId;
            this.WorkspaceId = workspaceId;
            this.IsUniversal = isUniversal;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        public Label()
        {
        }
    }
}