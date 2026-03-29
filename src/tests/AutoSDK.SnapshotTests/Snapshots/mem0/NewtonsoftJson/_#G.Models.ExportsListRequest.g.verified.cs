//HintName: G.Models.ExportsListRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportsListRequest
    {
        /// <summary>
        /// The unique identifier of the memory export.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory_export_id")]
        public string? MemoryExportId { get; set; }

        /// <summary>
        /// Filters to apply while exporting memories. Available fields are: user_id, agent_id, app_id, run_id, created_at, updated_at.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.ExportsListRequestFilters? Filters { get; set; }

        /// <summary>
        /// Filter exports by organization ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Filter exports by project ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsListRequest" /> class.
        /// </summary>
        /// <param name="memoryExportId">
        /// The unique identifier of the memory export.
        /// </param>
        /// <param name="filters">
        /// Filters to apply while exporting memories. Available fields are: user_id, agent_id, app_id, run_id, created_at, updated_at.
        /// </param>
        /// <param name="orgId">
        /// Filter exports by organization ID.
        /// </param>
        /// <param name="projectId">
        /// Filter exports by project ID.
        /// </param>
        public ExportsListRequest(
            string? memoryExportId,
            global::G.ExportsListRequestFilters? filters,
            string? orgId,
            string? projectId)
        {
            this.MemoryExportId = memoryExportId;
            this.Filters = filters;
            this.OrgId = orgId;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsListRequest" /> class.
        /// </summary>
        public ExportsListRequest()
        {
        }
    }
}