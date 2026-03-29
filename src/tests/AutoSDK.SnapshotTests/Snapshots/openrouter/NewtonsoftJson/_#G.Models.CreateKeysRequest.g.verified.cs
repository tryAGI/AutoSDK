//HintName: G.Models.CreateKeysRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKeysRequest
    {
        /// <summary>
        /// Name for the new API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional spending limit for the API key in USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit_reset")]
        public global::G.OneOf<global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>? LimitReset { get; set; }

        /// <summary>
        /// Whether to include BYOK usage in the limit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_byok_in_limit")]
        public bool? IncludeByokInLimit { get; set; }

        /// <summary>
        /// Optional ISO 8601 UTC timestamp when the API key should expire. Must be UTC, other timezones will be rejected
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeysRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new API key
        /// </param>
        /// <param name="limit">
        /// Optional spending limit for the API key in USD
        /// </param>
        /// <param name="limitReset">
        /// Type of limit reset for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit
        /// </param>
        /// <param name="expiresAt">
        /// Optional ISO 8601 UTC timestamp when the API key should expire. Must be UTC, other timezones will be rejected
        /// </param>
        public CreateKeysRequest(
            string name,
            double? limit,
            global::G.OneOf<global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset?, object>? limitReset,
            bool? includeByokInLimit,
            global::System.DateTime? expiresAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Limit = limit;
            this.LimitReset = limitReset;
            this.IncludeByokInLimit = includeByokInLimit;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeysRequest" /> class.
        /// </summary>
        public CreateKeysRequest()
        {
        }
    }
}