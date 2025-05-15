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
        [global::System.Text.Json.Serialization.JsonPropertyName("api_token_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiTokenName { get; set; }

        /// <summary>
        /// allow inference only to the specified model names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// how many seconds in the future should the token be valid for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_delta")]
        public int? ExpiresDelta { get; set; }

        /// <summary>
        /// unix timestamp when the token should expire
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// only allow spending that much USD until the token becomes invalid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spending_limit")]
        public double? SpendingLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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