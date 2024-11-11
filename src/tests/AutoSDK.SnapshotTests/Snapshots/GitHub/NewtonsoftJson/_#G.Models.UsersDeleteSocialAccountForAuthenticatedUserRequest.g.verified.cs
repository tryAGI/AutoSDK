//HintName: G.Models.UsersDeleteSocialAccountForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersDeleteSocialAccountForAuthenticatedUserRequest
    {
        /// <summary>
        /// Full URLs for the social media profiles to delete.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::Newtonsoft.Json.JsonProperty("account_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AccountUrls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersDeleteSocialAccountForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="accountUrls">
        /// Full URLs for the social media profiles to delete.<br/>
        /// Example: []
        /// </param>
        public UsersDeleteSocialAccountForAuthenticatedUserRequest(
            global::System.Collections.Generic.IList<string> accountUrls)
        {
            this.AccountUrls = accountUrls ?? throw new global::System.ArgumentNullException(nameof(accountUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersDeleteSocialAccountForAuthenticatedUserRequest" /> class.
        /// </summary>
        public UsersDeleteSocialAccountForAuthenticatedUserRequest()
        {
        }
    }
}