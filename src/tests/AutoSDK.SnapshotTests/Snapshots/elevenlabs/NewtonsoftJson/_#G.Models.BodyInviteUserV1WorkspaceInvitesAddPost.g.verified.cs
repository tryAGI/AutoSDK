//HintName: G.Models.BodyInviteUserV1WorkspaceInvitesAddPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyInviteUserV1WorkspaceInvitesAddPost
    {
        /// <summary>
        /// The email of the customer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// The group ids of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_ids")]
        public global::System.Collections.Generic.IList<string>? GroupIds { get; set; }

        /// <summary>
        /// The workspace permission of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_permission")]
        public global::G.BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2? WorkspacePermission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInviteUserV1WorkspaceInvitesAddPost" /> class.
        /// </summary>
        /// <param name="email">
        /// The email of the customer
        /// </param>
        /// <param name="groupIds">
        /// The group ids of the user
        /// </param>
        /// <param name="workspacePermission">
        /// The workspace permission of the user
        /// </param>
        public BodyInviteUserV1WorkspaceInvitesAddPost(
            string email,
            global::System.Collections.Generic.IList<string>? groupIds,
            global::G.BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission2? workspacePermission)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.GroupIds = groupIds;
            this.WorkspacePermission = workspacePermission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInviteUserV1WorkspaceInvitesAddPost" /> class.
        /// </summary>
        public BodyInviteUserV1WorkspaceInvitesAddPost()
        {
        }
    }
}