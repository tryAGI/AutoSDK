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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_name")]
        public string? TokenName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersInviteUsersServiceAccount" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tokenName"></param>
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