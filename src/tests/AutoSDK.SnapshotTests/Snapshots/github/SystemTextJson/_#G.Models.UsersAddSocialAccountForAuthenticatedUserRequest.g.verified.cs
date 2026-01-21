//HintName: G.Models.UsersAddSocialAccountForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"account_urls":["https://www.linkedin.com/company/github/","https://twitter.com/github"]}
    /// </summary>
    public sealed partial class UsersAddSocialAccountForAuthenticatedUserRequest
    {
        /// <summary>
        /// Full URLs for the social media profiles to add.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AccountUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersAddSocialAccountForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="accountUrls">
        /// Full URLs for the social media profiles to add.<br/>
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersAddSocialAccountForAuthenticatedUserRequest(
            global::System.Collections.Generic.IList<string> accountUrls)
        {
            this.AccountUrls = accountUrls ?? throw new global::System.ArgumentNullException(nameof(accountUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersAddSocialAccountForAuthenticatedUserRequest" /> class.
        /// </summary>
        public UsersAddSocialAccountForAuthenticatedUserRequest()
        {
        }
    }
}