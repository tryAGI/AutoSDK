//HintName: G.Models.PatchOrganizationMembersOutputAddedUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationMembersOutputAddedUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersOutputAddedUser" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="apiKey"></param>
        /// <param name="tokenName"></param>
        public PatchOrganizationMembersOutputAddedUser(
            global::System.Guid id,
            string? email,
            string? apiKey,
            string? tokenName)
        {
            this.Id = id;
            this.Email = email;
            this.ApiKey = apiKey;
            this.TokenName = tokenName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationMembersOutputAddedUser" /> class.
        /// </summary>
        public PatchOrganizationMembersOutputAddedUser()
        {
        }
    }
}