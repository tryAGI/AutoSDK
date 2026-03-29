//HintName: G.Models.PostAuthConfigsResponseAuthConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAuthConfigsResponseAuthConfig
    {
        /// <summary>
        /// The auth config id of the toolkit (must be a valid auth config id)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The authentication mode of the toolkit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_scheme", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthScheme { get; set; } = default!;

        /// <summary>
        /// Whether the auth config is managed by Composio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_composio_managed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsComposioManaged { get; set; } = default!;

        /// <summary>
        /// The tools that the user can use with the auth config<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restrict_to_following_tools")]
        public global::System.Collections.Generic.IList<string>? RestrictToFollowingTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsResponseAuthConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// The auth config id of the toolkit (must be a valid auth config id)
        /// </param>
        /// <param name="authScheme">
        /// The authentication mode of the toolkit
        /// </param>
        /// <param name="isComposioManaged">
        /// Whether the auth config is managed by Composio
        /// </param>
        /// <param name="restrictToFollowingTools">
        /// The tools that the user can use with the auth config<br/>
        /// Default Value: []
        /// </param>
        public PostAuthConfigsResponseAuthConfig(
            string id,
            string authScheme,
            bool isComposioManaged,
            global::System.Collections.Generic.IList<string>? restrictToFollowingTools)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AuthScheme = authScheme ?? throw new global::System.ArgumentNullException(nameof(authScheme));
            this.IsComposioManaged = isComposioManaged;
            this.RestrictToFollowingTools = restrictToFollowingTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsResponseAuthConfig" /> class.
        /// </summary>
        public PostAuthConfigsResponseAuthConfig()
        {
        }
    }
}