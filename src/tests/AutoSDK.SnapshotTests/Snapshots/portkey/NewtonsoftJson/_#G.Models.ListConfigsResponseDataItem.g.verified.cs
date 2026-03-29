//HintName: G.Models.ListConfigsResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListConfigsResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_default")]
        public int? IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id")]
        public global::System.Guid? OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_by")]
        public global::System.Guid? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfigsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="organisationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="isDefault"></param>
        /// <param name="status"></param>
        /// <param name="ownerId"></param>
        /// <param name="updatedBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        public ListConfigsResponseDataItem(
            global::System.Guid? id,
            string? name,
            string? slug,
            global::System.Guid? organisationId,
            global::System.Guid? workspaceId,
            int? isDefault,
            string? status,
            global::System.Guid? ownerId,
            global::System.Guid? updatedBy,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Slug = slug;
            this.OrganisationId = organisationId;
            this.WorkspaceId = workspaceId;
            this.IsDefault = isDefault;
            this.Status = status;
            this.OwnerId = ownerId;
            this.UpdatedBy = updatedBy;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfigsResponseDataItem" /> class.
        /// </summary>
        public ListConfigsResponseDataItem()
        {
        }
    }
}