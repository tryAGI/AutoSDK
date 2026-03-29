//HintName: G.Models.OAuthExchangeAuthCodeForAPIKeyResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuthExchangeAuthCodeForAPIKeyResponse200
    {
        /// <summary>
        /// The API key to use for OpenRouter requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// User ID associated with the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthExchangeAuthCodeForAPIKeyResponse200" /> class.
        /// </summary>
        /// <param name="key">
        /// The API key to use for OpenRouter requests
        /// </param>
        /// <param name="userId">
        /// User ID associated with the API key
        /// </param>
        public OAuthExchangeAuthCodeForAPIKeyResponse200(
            string key,
            string? userId)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthExchangeAuthCodeForAPIKeyResponse200" /> class.
        /// </summary>
        public OAuthExchangeAuthCodeForAPIKeyResponse200()
        {
        }
    }
}