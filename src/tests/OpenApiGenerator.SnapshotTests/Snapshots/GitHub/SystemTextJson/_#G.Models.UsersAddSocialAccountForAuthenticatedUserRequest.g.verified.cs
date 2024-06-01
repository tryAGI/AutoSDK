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
        [global::System.Text.Json.Serialization.JsonPropertyName("account_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AccountUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}