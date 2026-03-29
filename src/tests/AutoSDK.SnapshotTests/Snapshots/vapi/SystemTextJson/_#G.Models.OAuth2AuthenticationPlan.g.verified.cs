//HintName: G.Models.OAuth2AuthenticationPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuth2AuthenticationPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OAuth2AuthenticationPlanTypeJsonConverter))]
        public global::G.OAuth2AuthenticationPlanType Type { get; set; }

        /// <summary>
        /// This is the OAuth2 URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// This is the OAuth2 client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// This is the OAuth2 client secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// This is the scope of the OAuth2 token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2AuthenticationPlan" /> class.
        /// </summary>
        /// <param name="url">
        /// This is the OAuth2 URL.
        /// </param>
        /// <param name="clientId">
        /// This is the OAuth2 client ID.
        /// </param>
        /// <param name="clientSecret">
        /// This is the OAuth2 client secret.
        /// </param>
        /// <param name="type"></param>
        /// <param name="scope">
        /// This is the scope of the OAuth2 token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2AuthenticationPlan(
            string url,
            string clientId,
            string clientSecret,
            global::G.OAuth2AuthenticationPlanType type,
            string? scope)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2AuthenticationPlan" /> class.
        /// </summary>
        public OAuth2AuthenticationPlan()
        {
        }
    }
}