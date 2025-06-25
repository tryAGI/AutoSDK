//HintName: G.Models.AuditLogOrganizationUpdatedChangesRequested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to update the organization settings.
    /// </summary>
    public sealed partial class AuditLogOrganizationUpdatedChangesRequested
    {
        /// <summary>
        /// The organization title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The organization description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The organization name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Visibility of the threads page which shows messages created with the Assistants API and Playground. One of `ANY_ROLE`, `OWNERS`, or `NONE`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threads_ui_visibility")]
        public string? ThreadsUiVisibility { get; set; }

        /// <summary>
        /// Visibility of the usage dashboard which shows activity and costs for your organization. One of `ANY_ROLE` or `OWNERS`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_dashboard_visibility")]
        public string? UsageDashboardVisibility { get; set; }

        /// <summary>
        /// How your organization logs data from supported API calls. One of `disabled`, `enabled_per_call`, `enabled_for_all_projects`, or `enabled_for_selected_projects`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_call_logging")]
        public string? ApiCallLogging { get; set; }

        /// <summary>
        /// The list of project ids if api_call_logging is set to `enabled_for_selected_projects`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_call_logging_project_ids")]
        public string? ApiCallLoggingProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="title">
        /// The organization title.
        /// </param>
        /// <param name="description">
        /// The organization description.
        /// </param>
        /// <param name="name">
        /// The organization name.
        /// </param>
        /// <param name="threadsUiVisibility">
        /// Visibility of the threads page which shows messages created with the Assistants API and Playground. One of `ANY_ROLE`, `OWNERS`, or `NONE`.
        /// </param>
        /// <param name="usageDashboardVisibility">
        /// Visibility of the usage dashboard which shows activity and costs for your organization. One of `ANY_ROLE` or `OWNERS`.
        /// </param>
        /// <param name="apiCallLogging">
        /// How your organization logs data from supported API calls. One of `disabled`, `enabled_per_call`, `enabled_for_all_projects`, or `enabled_for_selected_projects`
        /// </param>
        /// <param name="apiCallLoggingProjectIds">
        /// The list of project ids if api_call_logging is set to `enabled_for_selected_projects`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogOrganizationUpdatedChangesRequested(
            string? title,
            string? description,
            string? name,
            string? threadsUiVisibility,
            string? usageDashboardVisibility,
            string? apiCallLogging,
            string? apiCallLoggingProjectIds)
        {
            this.Title = title;
            this.Description = description;
            this.Name = name;
            this.ThreadsUiVisibility = threadsUiVisibility;
            this.UsageDashboardVisibility = usageDashboardVisibility;
            this.ApiCallLogging = apiCallLogging;
            this.ApiCallLoggingProjectIds = apiCallLoggingProjectIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogOrganizationUpdatedChangesRequested()
        {
        }
    }
}