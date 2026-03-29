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
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The email address to use for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The API/ Access Token used for Basic, PAT and OAuth2 authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_token")]
        public string? ApiToken { get; set; }

        /// <summary>
        /// The server url for Jira Cloud.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_url")]
        public string? ServerUrl { get; set; }

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
        /// JQL (Jira Query Language) query to search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Default Value: CloudJiraDataSource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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