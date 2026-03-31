//HintName: G.Models.PatchOrganizationMembers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationMembers
    {
        /// <summary>
        /// Users to invite to the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_users")]
        public global::G.PatchOrganizationMembersInviteUsers? InviteUsers { get; set; }

        /// <summary>
        /// Users to remove from the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_users")]
        public global::G.PatchOrganizationMembersRemoveUsers? RemoveUsers { get; set; }

        /// <summary>
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, or in case you want to explicitly assert the organization you are modifying, you may specify the name of the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, or in case you want to explicitly assert the organization you are modifying, you may specify the id of the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembers" /> class.
        /// </summary>
        /// <param name="inviteUsers">
        /// Users to invite to the organization
        /// </param>
        /// <param name="removeUsers">
        /// Users to remove from the organization
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, or in case you want to explicitly assert the organization you are modifying, you may specify the name of the organization.
        /// </param>
        /// <param name="orgId">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, or in case you want to explicitly assert the organization you are modifying, you may specify the id of the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationMembers(
            global::G.PatchOrganizationMembersInviteUsers? inviteUsers,
            global::G.PatchOrganizationMembersRemoveUsers? removeUsers,
            string? orgName,
            string? orgId)
        {
            this.InviteUsers = inviteUsers;
            this.RemoveUsers = removeUsers;
            this.OrgName = orgName;
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembers" /> class.
        /// </summary>
        public PatchOrganizationMembers()
        {
        }
    }
}