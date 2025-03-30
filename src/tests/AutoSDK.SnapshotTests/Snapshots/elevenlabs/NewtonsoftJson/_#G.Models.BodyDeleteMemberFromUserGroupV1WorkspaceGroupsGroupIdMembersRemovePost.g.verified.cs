//HintName: G.Models.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost
    {
        /// <summary>
        /// The email of the target workspace member.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost" /> class.
        /// </summary>
        /// <param name="email">
        /// The email of the target workspace member.
        /// </param>
        public BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost(
            string email)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost" /> class.
        /// </summary>
        public BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost()
        {
        }
    }
}