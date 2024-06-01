//HintName: G.Models.UsersAddSocialAccountForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: 
    /// </summary>
    public sealed partial class UsersAddSocialAccountForAuthenticatedUserRequest
    {
        /// <summary>
        /// Full URLs for the social media profiles to add.
        /// <br/>Example: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AccountUrls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}