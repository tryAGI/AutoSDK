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
        [global::System.Text.Json.Serialization.JsonPropertyName("threads_ui_visibility")]
        public string? ThreadsUiVisibility { get; set; }

        /// <summary>
        /// Visibility of the usage dashboard which shows activity and costs for your organization. One of `ANY_ROLE` or `OWNERS`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_dashboard_visibility")]
        public string? UsageDashboardVisibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdatedChangesRequestedSettings" /> class.
        /// </summary>
        /// <param name="threadsUiVisibility">
        /// Visibility of the threads page which shows messages created with the Assistants API and Playground. One of `ANY_ROLE`, `OWNERS`, or `NONE`.
        /// </param>
        /// <param name="usageDashboardVisibility">
        /// Visibility of the usage dashboard which shows activity and costs for your organization. One of `ANY_ROLE` or `OWNERS`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogOrganizationUpdatedChangesRequestedSettings(
            string? threadsUiVisibility,
            string? usageDashboardVisibility)
        {
            this.ThreadsUiVisibility = threadsUiVisibility;
            this.UsageDashboardVisibility = usageDashboardVisibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdatedChangesRequestedSettings" /> class.
        /// </summary>
        public AuditLogOrganizationUpdatedChangesRequestedSettings()
        {
        }
    }
}