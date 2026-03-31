//HintName: G.Models.PatchOrganizationMembersInviteUsersServiceAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationMembersInviteUsersServiceAccount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_name")]
        public string? TokenName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersInviteUsersServiceAccount" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tokenName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationMembersInviteUsersServiceAccount(
            string name,
            string? tokenName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TokenName = tokenName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersInviteUsersServiceAccount" /> class.
        /// </summary>
        public PatchOrganizationMembersInviteUsersServiceAccount()
        {
        }
    }
}