//HintName: G.Models.CloudBoxDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudBoxDataSource
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The ID of the Box folder to read from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// The type of authentication to use (Developer Token or CCG)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication_mechanism")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BoxAuthMechanismJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BoxAuthMechanism AuthenticationMechanism { get; set; }

        /// <summary>
        /// Developer token for authentication if authentication_mechanism is 'developer_token'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("developer_token")]
        public string? DeveloperToken { get; set; }

        /// <summary>
        /// Box API key used for identifying the application the user is authenticating with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Box API secret used for making auth requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Box User ID, if provided authenticates as user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Box Enterprise ID, if provided authenticates as service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// Default Value: CloudBoxDataSource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudBoxDataSource" /> class.
        /// </summary>
        /// <param name="authenticationMechanism">
        /// The type of authentication to use (Developer Token or CCG)
        /// </param>
        /// <param name="supportsAccessControl">
        /// Default Value: false
        /// </param>
        /// <param name="folderId">
        /// The ID of the Box folder to read from.
        /// </param>
        /// <param name="developerToken">
        /// Developer token for authentication if authentication_mechanism is 'developer_token'.
        /// </param>
        /// <param name="clientId">
        /// Box API key used for identifying the application the user is authenticating with
        /// </param>
        /// <param name="clientSecret">
        /// Box API secret used for making auth requests.
        /// </param>
        /// <param name="userId">
        /// Box User ID, if provided authenticates as user.
        /// </param>
        /// <param name="enterpriseId">
        /// Box Enterprise ID, if provided authenticates as service.
        /// </param>
        /// <param name="className">
        /// Default Value: CloudBoxDataSource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudBoxDataSource(
            global::G.BoxAuthMechanism authenticationMechanism,
            bool? supportsAccessControl,
            string? folderId,
            string? developerToken,
            string? clientId,
            string? clientSecret,
            string? userId,
            string? enterpriseId,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.FolderId = folderId;
            this.AuthenticationMechanism = authenticationMechanism;
            this.DeveloperToken = developerToken;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.UserId = userId;
            this.EnterpriseId = enterpriseId;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudBoxDataSource" /> class.
        /// </summary>
        public CloudBoxDataSource()
        {
        }
    }
}