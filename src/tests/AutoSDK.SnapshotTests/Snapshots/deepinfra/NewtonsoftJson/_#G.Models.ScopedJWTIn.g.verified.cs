//HintName: G.Models.ScopedJWTIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScopedJWTIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_token_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiTokenName { get; set; } = default!;

        /// <summary>
        /// allow inference only to the specified model names
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// how many seconds in the future should the token be valid for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_delta")]
        public int? ExpiresDelta { get; set; }

        /// <summary>
        /// unix timestamp when the token should expire
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// only allow spending that much USD until the token becomes invalid
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spending_limit")]
        public double? SpendingLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedJWTIn" /> class.
        /// </summary>
        /// <param name="apiTokenName"></param>
        /// <param name="models">
        /// allow inference only to the specified model names
        /// </param>
        /// <param name="expiresDelta">
        /// how many seconds in the future should the token be valid for
        /// </param>
        /// <param name="expiresAt">
        /// unix timestamp when the token should expire
        /// </param>
        /// <param name="spendingLimit">
        /// only allow spending that much USD until the token becomes invalid
        /// </param>
        public ScopedJWTIn(
            string apiTokenName,
            global::System.Collections.Generic.IList<string>? models,
            int? expiresDelta,
            global::System.DateTimeOffset? expiresAt,
            double? spendingLimit)
        {
            this.ApiTokenName = apiTokenName ?? throw new global::System.ArgumentNullException(nameof(apiTokenName));
            this.Models = models;
            this.ExpiresDelta = expiresDelta;
            this.ExpiresAt = expiresAt;
            this.SpendingLimit = spendingLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedJWTIn" /> class.
        /// </summary>
        public ScopedJWTIn()
        {
        }
    }
}