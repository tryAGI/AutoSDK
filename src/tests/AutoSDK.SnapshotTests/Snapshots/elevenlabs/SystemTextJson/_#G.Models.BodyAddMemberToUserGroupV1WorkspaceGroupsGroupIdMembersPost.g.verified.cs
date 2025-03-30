//HintName: G.Models.BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost
    {
        /// <summary>
        /// The email of the target workspace member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost" /> class.
        /// </summary>
        /// <param name="email">
        /// The email of the target workspace member.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost(
            string email)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost" /> class.
        /// </summary>
        public BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost()
        {
        }
    }
}