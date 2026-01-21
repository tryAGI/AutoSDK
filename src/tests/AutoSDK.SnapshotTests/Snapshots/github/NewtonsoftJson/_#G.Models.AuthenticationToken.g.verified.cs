//HintName: G.Models.AuthenticationToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication Token
    /// </summary>
    public sealed partial class AuthenticationToken
    {
        /// <summary>
        /// The token used for authentication<br/>
        /// Example: v1.1f699f1069f60xxx
        /// </summary>
        /// <example>v1.1f699f1069f60xxx</example>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// The time this token expires<br/>
        /// Example: 2016-07-11T22:14:10Z
        /// </summary>
        /// <example>2016-07-11T22:14:10Z</example>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Example: {"issues":"read","deployments":"write"}
        /// </summary>
        /// <example>{"issues":"read","deployments":"write"}</example>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public object? Permissions { get; set; }

        /// <summary>
        /// The repositories this token has access to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories")]
        public global::System.Collections.Generic.IList<global::G.Repository>? Repositories { get; set; }

        /// <summary>
        /// Example: config.yaml
        /// </summary>
        /// <example>config.yaml</example>
        [global::Newtonsoft.Json.JsonProperty("single_file")]
        public string? SingleFile { get; set; }

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection")]
        public global::G.AuthenticationTokenRepositorySelection? RepositorySelection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationToken" /> class.
        /// </summary>
        /// <param name="token">
        /// The token used for authentication<br/>
        /// Example: v1.1f699f1069f60xxx
        /// </param>
        /// <param name="expiresAt">
        /// The time this token expires<br/>
        /// Example: 2016-07-11T22:14:10Z
        /// </param>
        /// <param name="permissions">
        /// Example: {"issues":"read","deployments":"write"}
        /// </param>
        /// <param name="repositories">
        /// The repositories this token has access to
        /// </param>
        /// <param name="singleFile">
        /// Example: config.yaml
        /// </param>
        /// <param name="repositorySelection">
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </param>
        public AuthenticationToken(
            string token,
            global::System.DateTime expiresAt,
            object? permissions,
            global::System.Collections.Generic.IList<global::G.Repository>? repositories,
            string? singleFile,
            global::G.AuthenticationTokenRepositorySelection? repositorySelection)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresAt = expiresAt;
            this.Permissions = permissions;
            this.Repositories = repositories;
            this.SingleFile = singleFile;
            this.RepositorySelection = repositorySelection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationToken" /> class.
        /// </summary>
        public AuthenticationToken()
        {
        }
    }
}