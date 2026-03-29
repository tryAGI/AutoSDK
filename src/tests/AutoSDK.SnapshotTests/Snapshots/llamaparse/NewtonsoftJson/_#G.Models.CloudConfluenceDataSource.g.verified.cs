//HintName: G.Models.CloudConfluenceDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudConfluenceDataSource
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The server URL of the Confluence instance.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerUrl { get; set; } = default!;

        /// <summary>
        /// Type of Authentication for connecting to Confluence APIs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authentication_mechanism", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthenticationMechanism { get; set; } = default!;

        /// <summary>
        /// The username to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// The API token to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_token")]
        public string? ApiToken { get; set; }

        /// <summary>
        /// The space key to read from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("space_key")]
        public string? SpaceKey { get; set; }

        /// <summary>
        /// The page IDs of the Confluence to read from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_ids")]
        public string? PageIds { get; set; }

        /// <summary>
        /// The CQL query to use for fetching pages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cql")]
        public string? Cql { get; set; }

        /// <summary>
        /// The label to use for fetching pages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Whether to index restricted pages.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_restricted_pages")]
        public bool? IndexRestrictedPages { get; set; }

        /// <summary>
        /// Whether to keep the markdown format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keep_markdown_format")]
        public bool? KeepMarkdownFormat { get; set; }

        /// <summary>
        /// Configuration for handling failures during processing. Key-value object controlling failure handling behaviors.<br/>
        /// Example:<br/>
        /// {<br/>
        ///   "skip_list_failures": true<br/>
        /// }<br/>
        /// Currently supports:<br/>
        /// - skip_list_failures: Skip failed batches/lists and continue processing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_handling")]
        public global::G.FailureHandlingConfig? FailureHandling { get; set; }

        /// <summary>
        /// Default Value: CloudConfluenceDataSource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudConfluenceDataSource" /> class.
        /// </summary>
        /// <param name="serverUrl">
        /// The server URL of the Confluence instance.
        /// </param>
        /// <param name="authenticationMechanism">
        /// Type of Authentication for connecting to Confluence APIs.
        /// </param>
        /// <param name="supportsAccessControl">
        /// Default Value: false
        /// </param>
        /// <param name="userName">
        /// The username to use for authentication.
        /// </param>
        /// <param name="apiToken">
        /// The API token to use for authentication.
        /// </param>
        /// <param name="spaceKey">
        /// The space key to read from.
        /// </param>
        /// <param name="pageIds">
        /// The page IDs of the Confluence to read from.
        /// </param>
        /// <param name="cql">
        /// The CQL query to use for fetching pages.
        /// </param>
        /// <param name="label">
        /// The label to use for fetching pages.
        /// </param>
        /// <param name="indexRestrictedPages">
        /// Whether to index restricted pages.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keepMarkdownFormat">
        /// Whether to keep the markdown format.
        /// </param>
        /// <param name="failureHandling">
        /// Configuration for handling failures during processing. Key-value object controlling failure handling behaviors.<br/>
        /// Example:<br/>
        /// {<br/>
        ///   "skip_list_failures": true<br/>
        /// }<br/>
        /// Currently supports:<br/>
        /// - skip_list_failures: Skip failed batches/lists and continue processing
        /// </param>
        /// <param name="className">
        /// Default Value: CloudConfluenceDataSource
        /// </param>
        public CloudConfluenceDataSource(
            string serverUrl,
            string authenticationMechanism,
            bool? supportsAccessControl,
            string? userName,
            string? apiToken,
            string? spaceKey,
            string? pageIds,
            string? cql,
            string? label,
            bool? indexRestrictedPages,
            bool? keepMarkdownFormat,
            global::G.FailureHandlingConfig? failureHandling,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.AuthenticationMechanism = authenticationMechanism ?? throw new global::System.ArgumentNullException(nameof(authenticationMechanism));
            this.UserName = userName;
            this.ApiToken = apiToken;
            this.SpaceKey = spaceKey;
            this.PageIds = pageIds;
            this.Cql = cql;
            this.Label = label;
            this.IndexRestrictedPages = indexRestrictedPages;
            this.KeepMarkdownFormat = keepMarkdownFormat;
            this.FailureHandling = failureHandling;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudConfluenceDataSource" /> class.
        /// </summary>
        public CloudConfluenceDataSource()
        {
        }
    }
}