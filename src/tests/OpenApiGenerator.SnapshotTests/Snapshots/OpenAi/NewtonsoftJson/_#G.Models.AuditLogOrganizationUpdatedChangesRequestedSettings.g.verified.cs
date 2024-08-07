//HintName: G.Models.AuditLogOrganizationUpdatedChangesRequestedSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuditLogOrganizationUpdatedChangesRequestedSettings
    {
        /// <summary>
        /// Visibility of the threads page which shows messages created with the Assistants API and Playground. One of `ANY_ROLE`, `OWNERS`, or `NONE`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threads_ui_visibility")]
        public string? ThreadsUiVisibility { get; set; }

        /// <summary>
        /// Visibility of the usage dashboard which shows activity and costs for your organization. One of `ANY_ROLE` or `OWNERS`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_dashboard_visibility")]
        public string? UsageDashboardVisibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}