//HintName: G.Models.CloudJiraDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cloud Jira Data Source integrating JiraReader.
    /// </summary>
    public sealed partial class CloudJiraDataSource
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The email address to use for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The API/ Access Token used for Basic, PAT and OAuth2 authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_token")]
        public string? ApiToken { get; set; }

        /// <summary>
        /// The server url for Jira Cloud.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// The cloud ID, used in case of OAuth2.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cloud_id")]
        public string? CloudId { get; set; }

        /// <summary>
        /// Type of Authentication for connecting to Jira APIs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authentication_mechanism", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthenticationMechanism { get; set; } = default!;

        /// <summary>
        /// JQL (Jira Query Language) query to search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// Default Value: CloudJiraDataSource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudJiraDataSource" /> class.
        /// </summary>
        /// <param name="authenticationMechanism">
        /// Type of Authentication for connecting to Jira APIs.
        /// </param>
        /// <param name="query">
        /// JQL (Jira Query Language) query to search.
        /// </param>
        /// <param name="supportsAccessControl">
        /// Default Value: false
        /// </param>
        /// <param name="email">
        /// The email address to use for authentication.
        /// </param>
        /// <param name="apiToken">
        /// The API/ Access Token used for Basic, PAT and OAuth2 authentication.
        /// </param>
        /// <param name="serverUrl">
        /// The server url for Jira Cloud.
        /// </param>
        /// <param name="cloudId">
        /// The cloud ID, used in case of OAuth2.
        /// </param>
        /// <param name="className">
        /// Default Value: CloudJiraDataSource
        /// </param>
        public CloudJiraDataSource(
            string authenticationMechanism,
            string query,
            bool? supportsAccessControl,
            string? email,
            string? apiToken,
            string? serverUrl,
            string? cloudId,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.Email = email;
            this.ApiToken = apiToken;
            this.ServerUrl = serverUrl;
            this.CloudId = cloudId;
            this.AuthenticationMechanism = authenticationMechanism ?? throw new global::System.ArgumentNullException(nameof(authenticationMechanism));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudJiraDataSource" /> class.
        /// </summary>
        public CloudJiraDataSource()
        {
        }
    }
}