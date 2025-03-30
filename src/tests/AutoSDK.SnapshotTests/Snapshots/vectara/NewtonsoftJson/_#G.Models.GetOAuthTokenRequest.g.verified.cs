//HintName: G.Models.GetOAuthTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOAuthTokenRequest
    {
        /// <summary>
        /// The client ID of the application
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// The client secret of the application
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientSecret { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grant_type", Required = global::Newtonsoft.Json.Required.Always)]
        public object GrantType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOAuthTokenRequest" /> class.
        /// </summary>
        /// <param name="clientId">
        /// The client ID of the application
        /// </param>
        /// <param name="clientSecret">
        /// The client secret of the application
        /// </param>
        /// <param name="grantType"></param>
        public GetOAuthTokenRequest(
            string clientId,
            string clientSecret,
            object grantType)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.GrantType = grantType ?? throw new global::System.ArgumentNullException(nameof(grantType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOAuthTokenRequest" /> class.
        /// </summary>
        public GetOAuthTokenRequest()
        {
        }
    }
}