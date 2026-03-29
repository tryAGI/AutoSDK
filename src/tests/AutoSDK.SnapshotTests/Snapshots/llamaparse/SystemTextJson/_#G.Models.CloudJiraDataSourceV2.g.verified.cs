//HintName: G.Models.CloudJiraDataSourceV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cloud Jira Data Source integrating JiraReaderV2.
    /// </summary>
    public sealed partial class CloudJiraDataSourceV2
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The email address to use for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The API Access Token used for Basic, PAT and OAuth2 authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_token")]
        public string? ApiToken { get; set; }

        /// <summary>
        /// The server url for Jira Cloud.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerUrl { get; set; }

        /// <summary>
        /// The cloud ID, used in case of OAuth2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_id")]
        public string? CloudId { get; set; }

        /// <summary>
        /// Type of Authentication for connecting to Jira APIs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication_mechanism")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthenticationMechanism { get; set; }

        /// <summary>
        /// Jira REST API version to use (2 or 3). 3 supports Atlassian Document Format (ADF).<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CloudJiraDataSourceV2ApiVersionJsonConverter))]
        public global::G.CloudJiraDataSourceV2ApiVersion? ApiVersion { get; set; }

        /// <summary>
        /// JQL (Jira Query Language) query to search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// List of fields to retrieve from Jira. If None, retrieves all fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<string>? Fields { get; set; }

        /// <summary>
        /// Fields to expand in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// Rate limit for Jira API requests per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_minute")]
        public int? RequestsPerMinute { get; set; }

        /// <summary>
        /// Whether to fetch project role permissions and issue-level security<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get_permissions")]
        public bool? GetPermissions { get; set; }

        /// <summary>
        /// Default Value: CloudJiraDataSourceV2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudJiraDataSourceV2" /> class.
        /// </summary>
        /// <param name="serverUrl">
        /// The server url for Jira Cloud.
        /// </param>
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
        /// The API Access Token used for Basic, PAT and OAuth2 authentication.
        /// </param>
        /// <param name="cloudId">
        /// The cloud ID, used in case of OAuth2.
        /// </param>
        /// <param name="apiVersion">
        /// Jira REST API version to use (2 or 3). 3 supports Atlassian Document Format (ADF).<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="fields">
        /// List of fields to retrieve from Jira. If None, retrieves all fields.
        /// </param>
        /// <param name="expand">
        /// Fields to expand in the response.
        /// </param>
        /// <param name="requestsPerMinute">
        /// Rate limit for Jira API requests per minute.
        /// </param>
        /// <param name="getPermissions">
        /// Whether to fetch project role permissions and issue-level security<br/>
        /// Default Value: true
        /// </param>
        /// <param name="className">
        /// Default Value: CloudJiraDataSourceV2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudJiraDataSourceV2(
            string serverUrl,
            string authenticationMechanism,
            string query,
            bool? supportsAccessControl,
            string? email,
            string? apiToken,
            string? cloudId,
            global::G.CloudJiraDataSourceV2ApiVersion? apiVersion,
            global::System.Collections.Generic.IList<string>? fields,
            string? expand,
            int? requestsPerMinute,
            bool? getPermissions,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.Email = email;
            this.ApiToken = apiToken;
            this.ServerUrl = serverUrl ?? throw new global::System.ArgumentNullException(nameof(serverUrl));
            this.CloudId = cloudId;
            this.AuthenticationMechanism = authenticationMechanism ?? throw new global::System.ArgumentNullException(nameof(authenticationMechanism));
            this.ApiVersion = apiVersion;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Fields = fields;
            this.Expand = expand;
            this.RequestsPerMinute = requestsPerMinute;
            this.GetPermissions = getPermissions;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudJiraDataSourceV2" /> class.
        /// </summary>
        public CloudJiraDataSourceV2()
        {
        }
    }
}