//HintName: G.Models.PostApiKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostApiKeyResponse
    {
        /// <summary>
        /// The API key to use when making authenticated requests with the API. This key will only be shown once.<br/>
        /// Example: vkpDjaKdMNR8QJ83GjfNvFZJbnoi65XUp70MgZNtA2H9XE8yfDnmr_6BaRyQkF9hnJzu6mUPRLBmqlnZMwetJA
        /// </summary>
        /// <example>vkpDjaKdMNR8QJ83GjfNvFZJbnoi65XUp70MgZNtA2H9XE8yfDnmr_6BaRyQkF9hnJzu6mUPRLBmqlnZMwetJA</example>
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// The ID of the API key. A URL safe base64 encoded UUID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg==
        /// </summary>
        /// <example>JRPVD7jWR1aTBYiJ0UFVOg==</example>
        [global::Newtonsoft.Json.JsonProperty("api_key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKeyId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiKeyResponse" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// The API key to use when making authenticated requests with the API. This key will only be shown once.<br/>
        /// Example: vkpDjaKdMNR8QJ83GjfNvFZJbnoi65XUp70MgZNtA2H9XE8yfDnmr_6BaRyQkF9hnJzu6mUPRLBmqlnZMwetJA
        /// </param>
        /// <param name="apiKeyId">
        /// The ID of the API key. A URL safe base64 encoded UUID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg==
        /// </param>
        public PostApiKeyResponse(
            string apiKey,
            string apiKeyId)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostApiKeyResponse" /> class.
        /// </summary>
        public PostApiKeyResponse()
        {
        }
    }
}