//HintName: G.Models.BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost
    {
        /// <summary>
        /// The email of the customer<br/>
        /// Example: john.doe@testmail.com
        /// </summary>
        /// <example>john.doe@testmail.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// The group ids of the user<br/>
        /// Example: [group_id_1, group_id_2]
        /// </summary>
        /// <example>[group_id_1, group_id_2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_ids")]
        public global::System.Collections.Generic.IList<string>? GroupIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost" /> class.
        /// </summary>
        /// <param name="emails">
        /// The email of the customer<br/>
        /// Example: john.doe@testmail.com
        /// </param>
        /// <param name="groupIds">
        /// The group ids of the user<br/>
        /// Example: [group_id_1, group_id_2]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost(
            global::System.Collections.Generic.IList<string> emails,
            global::System.Collections.Generic.IList<string>? groupIds)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.GroupIds = groupIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost" /> class.
        /// </summary>
        public BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost()
        {
        }
    }
}