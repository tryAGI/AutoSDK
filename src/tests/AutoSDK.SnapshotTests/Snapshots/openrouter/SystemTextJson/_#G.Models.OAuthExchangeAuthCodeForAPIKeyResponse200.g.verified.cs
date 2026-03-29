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
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// User ID associated with the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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