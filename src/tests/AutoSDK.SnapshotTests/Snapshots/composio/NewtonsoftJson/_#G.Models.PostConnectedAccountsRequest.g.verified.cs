//HintName: G.Models.PostConnectedAccountsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostConnectedAccountsRequestAuthConfig AuthConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connection", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostConnectedAccountsRequestConnection Connection { get; set; } = default!;

        /// <summary>
        /// [EXPERIMENTAL] Whether to validate the provided credentials, validates only for API Key Auth scheme<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validate_credentials")]
        public bool? ValidateCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequest" /> class.
        /// </summary>
        /// <param name="authConfig"></param>
        /// <param name="connection"></param>
        /// <param name="validateCredentials">
        /// [EXPERIMENTAL] Whether to validate the provided credentials, validates only for API Key Auth scheme<br/>
        /// Default Value: false
        /// </param>
        public PostConnectedAccountsRequest(
            global::G.PostConnectedAccountsRequestAuthConfig authConfig,
            global::G.PostConnectedAccountsRequestConnection connection,
            bool? validateCredentials)
        {
            this.AuthConfig = authConfig ?? throw new global::System.ArgumentNullException(nameof(authConfig));
            this.Connection = connection ?? throw new global::System.ArgumentNullException(nameof(connection));
            this.ValidateCredentials = validateCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequest" /> class.
        /// </summary>
        public PostConnectedAccountsRequest()
        {
        }
    }
}