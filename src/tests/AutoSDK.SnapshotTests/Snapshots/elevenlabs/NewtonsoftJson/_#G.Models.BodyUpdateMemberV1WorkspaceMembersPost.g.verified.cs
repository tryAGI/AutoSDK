//HintName: G.Models.BodyUpdateMemberV1WorkspaceMembersPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateMemberV1WorkspaceMembersPost
    {
        /// <summary>
        /// Email of the target user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Whether to lock or unlock the user account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_locked")]
        public bool? IsLocked { get; set; }

        /// <summary>
        /// Role dictating permissions in the workspace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_role")]
        public global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole? WorkspaceRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}