//HintName: G.Models.AppsCreateInstallationAccessTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsCreateInstallationAccessTokenRequest
    {
        /// <summary>
        /// List of repository names that the token should have access to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<string?>? Repositories { get; set; }

        /// <summary>
        /// List of repository IDs that the token should have access to<br/>
        /// Example: [1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_ids")]
        public global::System.Collections.Generic.IList<int>? RepositoryIds { get; set; }

        /// <summary>
        /// The permissions granted to the user access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::G.AppPermissions? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}