//HintName: G.Models.PatchOrganizationMembersInviteUsers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Users to invite to the organization
    /// </summary>
    public sealed partial class PatchOrganizationMembersInviteUsers
    {
        /// <summary>
        /// Ids of existing users to invite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Ids { get; set; }

        /// <summary>
        /// Emails of users to invite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        public global::System.Collections.Generic.IList<string>? Emails { get; set; }

        /// <summary>
        /// Service accounts to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_accounts")]
        public global::System.Collections.Generic.IList<global::G.PatchOrganizationMembersInviteUsersServiceAccount>? ServiceAccounts { get; set; }

        /// <summary>
        /// If true, send invite emails to the users who wore actually added
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_invite_emails")]
        public bool? SendInviteEmails { get; set; }

        /// <summary>
        /// Optional list of group ids to add newly-invited users to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? GroupIds { get; set; }

        /// <summary>
        /// Optional list of group names to add newly-invited users to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_names")]
        public global::System.Collections.Generic.IList<string>? GroupNames { get; set; }

        /// <summary>
        /// Singular form of group_ids
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public global::System.Guid? GroupId { get; set; }

        /// <summary>
        /// Singular form of group_names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string? GroupName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersInviteUsers" /> class.
        /// </summary>
        /// <param name="ids">
        /// Ids of existing users to invite
        /// </param>
        /// <param name="emails">
        /// Emails of users to invite
        /// </param>
        /// <param name="serviceAccounts">
        /// Service accounts to create
        /// </param>
        /// <param name="sendInviteEmails">
        /// If true, send invite emails to the users who wore actually added
        /// </param>
        /// <param name="groupIds">
        /// Optional list of group ids to add newly-invited users to.
        /// </param>
        /// <param name="groupNames">
        /// Optional list of group names to add newly-invited users to.
        /// </param>
        /// <param name="groupId">
        /// Singular form of group_ids
        /// </param>
        /// <param name="groupName">
        /// Singular form of group_names
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationMembersInviteUsers(
            global::System.Collections.Generic.IList<global::System.Guid>? ids,
            global::System.Collections.Generic.IList<string>? emails,
            global::System.Collections.Generic.IList<global::G.PatchOrganizationMembersInviteUsersServiceAccount>? serviceAccounts,
            bool? sendInviteEmails,
            global::System.Collections.Generic.IList<global::System.Guid>? groupIds,
            global::System.Collections.Generic.IList<string>? groupNames,
            global::System.Guid? groupId,
            string? groupName)
        {
            this.Ids = ids;
            this.Emails = emails;
            this.ServiceAccounts = serviceAccounts;
            this.SendInviteEmails = sendInviteEmails;
            this.GroupIds = groupIds;
            this.GroupNames = groupNames;
            this.GroupId = groupId;
            this.GroupName = groupName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersInviteUsers" /> class.
        /// </summary>
        public PatchOrganizationMembersInviteUsers()
        {
        }
    }
}