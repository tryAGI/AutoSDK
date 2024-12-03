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
        /// <example>e72e16c7e42f292c6912e7710c838347ae178b4a</example>
        [global::Newtonsoft.Json.JsonProperty("access_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessToken { get; set; } = default!;

        /// <summary>
        /// The name of the user or organization to scope the user access token to. **Required** unless `target_id` is specified.<br/>
        /// Example: octocat
        /// </summary>
        /// <example>octocat</example>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public string? Target { get; set; }

        /// <summary>
        /// The ID of the user or organization to scope the user access token to. **Required** unless `target` is specified.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("target_id")]
        public int? TargetId { get; set; }

        /// <summary>
        /// The list of repository names to scope the user access token to. `repositories` may not be specified if `repository_ids` is specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories")]
        public global::System.Collections.Generic.IList<string>? Repositories { get; set; }

        /// <summary>
        /// The list of repository IDs to scope the user access token to. `repository_ids` may not be specified if `repositories` is specified.<br/>
        /// Example: [1]
        /// </summary>
        /// <example>[1]</example>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsScopeTokenRequest" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// The access token used to authenticate to the GitHub API.<br/>
        /// Example: e72e16c7e42f292c6912e7710c838347ae178b4a
        /// </param>
        /// <param name="target">
        /// The name of the user or organization to scope the user access token to. **Required** unless `target_id` is specified.<br/>
        /// Example: octocat
        /// </param>
        /// <param name="targetId">
        /// The ID of the user or organization to scope the user access token to. **Required** unless `target` is specified.<br/>
        /// Example: 1
        /// </param>
        /// <param name="repositories">
        /// The list of repository names to scope the user access token to. `repositories` may not be specified if `repository_ids` is specified.
        /// </param>
        /// <param name="repositoryIds">
        /// The list of repository IDs to scope the user access token to. `repository_ids` may not be specified if `repositories` is specified.<br/>
        /// Example: [1]
        /// </param>
        /// <param name="permissions">
        /// The permissions granted to the user access token.
        /// </param>
        public AppsScopeTokenRequest(
            string accessToken,
            string? target,
            int? targetId,
            global::System.Collections.Generic.IList<string>? repositories,
            global::System.Collections.Generic.IList<int>? repositoryIds,
            global::G.AppPermissions? permissions)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.Target = target;
            this.TargetId = targetId;
            this.Repositories = repositories;
            this.RepositoryIds = repositoryIds;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsScopeTokenRequest" /> class.
        /// </summary>
        public AppsScopeTokenRequest()
        {
        }
    }
}