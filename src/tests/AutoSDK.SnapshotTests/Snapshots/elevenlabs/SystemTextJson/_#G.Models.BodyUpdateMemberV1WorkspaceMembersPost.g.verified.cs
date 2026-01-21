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
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Whether to lock or unlock the user account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_locked")]
        public bool? IsLocked { get; set; }

        /// <summary>
        /// Role dictating permissions in the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_role")]
        public global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2? WorkspaceRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateMemberV1WorkspaceMembersPost" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of the target user.
        /// </param>
        /// <param name="isLocked">
        /// Whether to lock or unlock the user account.
        /// </param>
        /// <param name="workspaceRole">
        /// Role dictating permissions in the workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateMemberV1WorkspaceMembersPost(
            string email,
            bool? isLocked,
            global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole2? workspaceRole)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.IsLocked = isLocked;
            this.WorkspaceRole = workspaceRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateMemberV1WorkspaceMembersPost" /> class.
        /// </summary>
        public BodyUpdateMemberV1WorkspaceMembersPost()
        {
        }
    }
}