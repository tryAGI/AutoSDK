//HintName: G.Models.ListConfigVersionsResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListConfigVersionsResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public int? IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public global::System.Guid? OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public global::System.Guid? UpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Serialized configuration for this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public string? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public global::System.Guid? VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfigVersionsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="workspaceId"></param>
        /// <param name="slug"></param>
        /// <param name="organisationId"></param>
        /// <param name="isDefault"></param>
        /// <param name="status"></param>
        /// <param name="ownerId"></param>
        /// <param name="updatedBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="config">
        /// Serialized configuration for this version
        /// </param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="versionId"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListConfigVersionsResponseDataItem(
            global::System.Guid? id,
            string? name,
            global::System.Guid? workspaceId,
            string? slug,
            global::System.Guid? organisationId,
            int? isDefault,
            string? status,
            global::System.Guid? ownerId,
            global::System.Guid? updatedBy,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            string? config,
            string? format,
            string? type,
            global::System.Guid? versionId,
            string? @object)
        {
            this.Id = id;
            this.Name = name;
            this.WorkspaceId = workspaceId;
            this.Slug = slug;
            this.OrganisationId = organisationId;
            this.IsDefault = isDefault;
            this.Status = status;
            this.OwnerId = ownerId;
            this.UpdatedBy = updatedBy;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Config = config;
            this.Format = format;
            this.Type = type;
            this.VersionId = versionId;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfigVersionsResponseDataItem" /> class.
        /// </summary>
        public ListConfigVersionsResponseDataItem()
        {
        }
    }
}