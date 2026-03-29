//HintName: G.Models.WorkspaceUserPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceUserPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceName")]
        public string? WorkspaceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::G.Permission>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUserPermissions" /> class.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="workspaceName"></param>
        /// <param name="permissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceUserPermissions(
            string? userName,
            string? workspaceName,
            global::System.Collections.Generic.IList<global::G.Permission>? permissions)
        {
            this.UserName = userName;
            this.WorkspaceName = workspaceName;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUserPermissions" /> class.
        /// </summary>
        public WorkspaceUserPermissions()
        {
        }
    }
}