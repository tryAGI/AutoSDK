//HintName: G.Models.UserTeam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Simple schema for returning info about teams a user is in, plus their<br/>
    /// role in that team.
    /// </summary>
    public sealed partial class UserTeam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Defines various account tiers with different access levels and permissions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AccountTier AccountTier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}