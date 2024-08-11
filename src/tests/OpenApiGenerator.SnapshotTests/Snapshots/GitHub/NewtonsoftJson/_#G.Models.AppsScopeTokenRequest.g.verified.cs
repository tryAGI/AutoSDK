//HintName: G.Models.AppsScopeTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsScopeTokenRequest
    {
        /// <summary>
        /// The access token used to authenticate to the GitHub API.<br/>
        /// Example: e72e16c7e42f292c6912e7710c838347ae178b4a
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessToken { get; set; } = default!;

        /// <summary>
        /// The name of the user or organization to scope the user access token to. **Required** unless `target_id` is specified.<br/>
        /// Example: octocat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public string? Target { get; set; }

        /// <summary>
        /// The ID of the user or organization to scope the user access token to. **Required** unless `target` is specified.<br/>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_id")]
        public int TargetId { get; set; }

        /// <summary>
        /// The list of repository names to scope the user access token to. `repositories` may not be specified if `repository_ids` is specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories")]
        public global::System.Collections.Generic.IList<string>? Repositories { get; set; }

        /// <summary>
        /// The list of repository IDs to scope the user access token to. `repository_ids` may not be specified if `repositories` is specified.<br/>
        /// Example: [1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_ids")]
        public global::System.Collections.Generic.IList<int>? RepositoryIds { get; set; }

        /// <summary>
        /// The permissions granted to the user access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::G.AppPermissions? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}