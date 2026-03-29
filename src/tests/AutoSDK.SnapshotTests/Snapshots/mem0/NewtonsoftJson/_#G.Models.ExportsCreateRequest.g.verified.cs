//HintName: G.Models.ExportsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportsCreateRequest
    {
        /// <summary>
        /// Schema definition for the export
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object Schema { get; set; } = default!;

        /// <summary>
        /// Filters to apply while exporting memories. Available fields are: user_id, agent_id, app_id, run_id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.ExportsCreateRequestFilters? Filters { get; set; }

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
        /// Initializes a new instance of the <see cref="ExportsCreateRequest" /> class.
        /// </summary>
        /// <param name="schema">
        /// Schema definition for the export
        /// </param>
        /// <param name="filters">
        /// Filters to apply while exporting memories. Available fields are: user_id, agent_id, app_id, run_id.
        /// </param>
        /// <param name="orgId">
        /// Filter exports by organization ID.
        /// </param>
        /// <param name="projectId">
        /// Filter exports by project ID.
        /// </param>
        public ExportsCreateRequest(
            object schema,
            global::G.ExportsCreateRequestFilters? filters,
            string? orgId,
            string? projectId)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Filters = filters;
            this.OrgId = orgId;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateRequest" /> class.
        /// </summary>
        public ExportsCreateRequest()
        {
        }
    }
}