//HintName: G.Models.PatchOrganizationMembersRemoveUsers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Users to remove from the organization
    /// </summary>
    public sealed partial class PatchOrganizationMembersRemoveUsers
    {
        /// <summary>
        /// Ids of users to remove
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Ids { get; set; }

        /// <summary>
        /// Emails of users to remove
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        public global::System.Collections.Generic.IList<string>? Emails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersRemoveUsers" /> class.
        /// </summary>
        /// <param name="ids">
        /// Ids of users to remove
        /// </param>
        /// <param name="emails">
        /// Emails of users to remove
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationMembersRemoveUsers(
            global::System.Collections.Generic.IList<global::System.Guid>? ids,
            global::System.Collections.Generic.IList<string>? emails)
        {
            this.Ids = ids;
            this.Emails = emails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersRemoveUsers" /> class.
        /// </summary>
        public PatchOrganizationMembersRemoveUsers()
        {
        }
    }
}