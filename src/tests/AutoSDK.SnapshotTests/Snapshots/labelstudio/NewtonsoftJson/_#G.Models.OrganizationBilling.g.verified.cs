//HintName: G.Models.OrganizationBilling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationBilling
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("enforce_session_concurrency")]
        public string EnforceSessionConcurrency { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("manual_role_management")]
        public string ManualRoleManagement { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("manual_workspace_management")]
        public string ManualWorkspaceManagement { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("max_parallel_sessions")]
        public string MaxParallelSessions { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("session_concurrency_window_seconds")]
        public string SessionConcurrencyWindowSeconds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationBilling" /> class.
        /// </summary>
        /// <param name="enforceSessionConcurrency">
        /// Included only in responses
        /// </param>
        /// <param name="manualRoleManagement">
        /// Included only in responses
        /// </param>
        /// <param name="manualWorkspaceManagement">
        /// Included only in responses
        /// </param>
        /// <param name="maxParallelSessions">
        /// Included only in responses
        /// </param>
        /// <param name="sessionConcurrencyWindowSeconds">
        /// Included only in responses
        /// </param>
        public OrganizationBilling(
            string enforceSessionConcurrency = default!,
            string manualRoleManagement = default!,
            string manualWorkspaceManagement = default!,
            string maxParallelSessions = default!,
            string sessionConcurrencyWindowSeconds = default!)
        {
            this.EnforceSessionConcurrency = enforceSessionConcurrency;
            this.ManualRoleManagement = manualRoleManagement;
            this.ManualWorkspaceManagement = manualWorkspaceManagement;
            this.MaxParallelSessions = maxParallelSessions;
            this.SessionConcurrencyWindowSeconds = sessionConcurrencyWindowSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationBilling" /> class.
        /// </summary>
        public OrganizationBilling()
        {
        }
    }
}