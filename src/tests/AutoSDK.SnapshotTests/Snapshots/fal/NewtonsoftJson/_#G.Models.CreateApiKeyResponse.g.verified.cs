//HintName: G.Models.CreateApiKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing the newly created API key credentials. The key_secret is only returned once.
    /// </summary>
    public sealed partial class CreateApiKeyResponse
    {
        /// <summary>
        /// Unique identifier for the newly created API key<br/>
        /// Example: abc123def456
        /// </summary>
        /// <example>abc123def456</example>
        [global::Newtonsoft.Json.JsonProperty("key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyId { get; set; } = default!;

        /// <summary>
        /// Secret portion of the API key. IMPORTANT: This is only returned once at creation time and cannot be retrieved again.<br/>
        /// Example: sk_live_abc123...
        /// </summary>
        /// <example>sk_live_abc123...</example>
        [global::Newtonsoft.Json.JsonProperty("key_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeySecret { get; set; } = default!;

        /// <summary>
        /// Full API key in the format 'key_id:key_secret'. Use this value directly for API authorization. IMPORTANT: This is only returned once at creation time and cannot be retrieved again.<br/>
        /// Example: abc123def456:sk_live_abc123...
        /// </summary>
        /// <example>abc123def456:sk_live_abc123...</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyResponse" /> class.
        /// </summary>
        /// <param name="keyId">
        /// Unique identifier for the newly created API key<br/>
        /// Example: abc123def456
        /// </param>
        /// <param name="keySecret">
        /// Secret portion of the API key. IMPORTANT: This is only returned once at creation time and cannot be retrieved again.<br/>
        /// Example: sk_live_abc123...
        /// </param>
        /// <param name="key">
        /// Full API key in the format 'key_id:key_secret'. Use this value directly for API authorization. IMPORTANT: This is only returned once at creation time and cannot be retrieved again.<br/>
        /// Example: abc123def456:sk_live_abc123...
        /// </param>
        public CreateApiKeyResponse(
            string keyId,
            string keySecret,
            string key)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.KeySecret = keySecret ?? throw new global::System.ArgumentNullException(nameof(keySecret));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyResponse" /> class.
        /// </summary>
        public CreateApiKeyResponse()
        {
        }
    }
}