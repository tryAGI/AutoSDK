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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OAuth2AuthenticationPlanType Type { get; set; }

        /// <summary>
        /// This is the OAuth2 URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// This is the OAuth2 client ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// This is the OAuth2 client secret.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientSecret", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientSecret { get; set; } = default!;

        /// <summary>
        /// This is the scope of the OAuth2 token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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