//HintName: G.Models.ExportItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organisation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrganisationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GenerationsFilterSchema Filters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem> RequestedData { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExportItemStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CreatedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid WorkspaceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ExportItemObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organisationId"></param>
        /// <param name="filters"></param>
        /// <param name="requestedData"></param>
        /// <param name="status"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="workspaceId"></param>
        /// <param name="object"></param>
        public ExportItem(
            global::System.Guid id,
            global::System.Guid organisationId,
            global::G.GenerationsFilterSchema filters,
            global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem> requestedData,
            global::G.ExportItemStatus status,
            string description,
            global::System.DateTime createdAt,
            global::System.DateTime lastUpdatedAt,
            global::System.Guid createdBy,
            global::System.Guid workspaceId,
            global::G.ExportItemObject @object)
        {
            this.Id = id;
            this.OrganisationId = organisationId;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.RequestedData = requestedData ?? throw new global::System.ArgumentNullException(nameof(requestedData));
            this.Status = status;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.CreatedBy = createdBy;
            this.WorkspaceId = workspaceId;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportItem" /> class.
        /// </summary>
        public ExportItem()
        {
        }
    }
}