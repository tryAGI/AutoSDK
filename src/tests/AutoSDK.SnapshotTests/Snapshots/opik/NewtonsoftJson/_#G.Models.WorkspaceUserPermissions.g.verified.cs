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
        [global::Newtonsoft.Json.JsonProperty("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspaceName")]
        public string? WorkspaceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::System.Collections.Generic.IList<global::G.Permission>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUserPermissions" /> class.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="workspaceName"></param>
        /// <param name="permissions"></param>
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