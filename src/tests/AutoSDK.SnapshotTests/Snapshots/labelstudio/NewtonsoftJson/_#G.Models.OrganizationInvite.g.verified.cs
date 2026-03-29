//HintName: G.Models.OrganizationInvite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationInvite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invite_url")]
        public string? InviteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvite" /> class.
        /// </summary>
        /// <param name="inviteUrl"></param>
        /// <param name="token"></param>
        public OrganizationInvite(
            string? inviteUrl,
            string? token)
        {
            this.InviteUrl = inviteUrl;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvite" /> class.
        /// </summary>
        public OrganizationInvite()
        {
        }
    }
}