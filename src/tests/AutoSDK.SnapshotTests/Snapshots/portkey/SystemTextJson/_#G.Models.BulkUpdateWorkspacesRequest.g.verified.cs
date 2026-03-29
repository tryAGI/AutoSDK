//HintName: G.Models.BulkUpdateWorkspacesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateWorkspacesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        public global::System.Collections.Generic.IList<global::G.WorkspaceUpdateRequest>? Workspaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_workspace_access")]
        public global::G.GlobalWorkspaceAccess? GlobalWorkspaceAccess { get; set; }

        /// <summary>
        /// Whether to override existing workspace access settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_existing_workspace_access")]
        public bool? OverrideExistingWorkspaceAccess { get; set; }

        /// <summary>
        /// Whether to automatically create a default provider when granting workspace access. Defaults to true. Can be overridden per workspace.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_default_provider")]
        public bool? CreateDefaultProvider { get; set; }

        /// <summary>
        /// Custom slug for the auto-created default provider. Applies to all workspaces unless overridden per workspace. If the slug already exists, the request will fail with a validation error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_provider_slug")]
        public string? DefaultProviderSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateWorkspacesRequest" /> class.
        /// </summary>
        /// <param name="workspaces"></param>
        /// <param name="globalWorkspaceAccess"></param>
        /// <param name="overrideExistingWorkspaceAccess">
        /// Whether to override existing workspace access settings
        /// </param>
        /// <param name="createDefaultProvider">
        /// Whether to automatically create a default provider when granting workspace access. Defaults to true. Can be overridden per workspace.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="defaultProviderSlug">
        /// Custom slug for the auto-created default provider. Applies to all workspaces unless overridden per workspace. If the slug already exists, the request will fail with a validation error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateWorkspacesRequest(
            global::System.Collections.Generic.IList<global::G.WorkspaceUpdateRequest>? workspaces,
            global::G.GlobalWorkspaceAccess? globalWorkspaceAccess,
            bool? overrideExistingWorkspaceAccess,
            bool? createDefaultProvider,
            string? defaultProviderSlug)
        {
            this.Workspaces = workspaces;
            this.GlobalWorkspaceAccess = globalWorkspaceAccess;
            this.OverrideExistingWorkspaceAccess = overrideExistingWorkspaceAccess;
            this.CreateDefaultProvider = createDefaultProvider;
            this.DefaultProviderSlug = defaultProviderSlug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateWorkspacesRequest" /> class.
        /// </summary>
        public BulkUpdateWorkspacesRequest()
        {
        }
    }
}