//HintName: G.Models.BearerAuthenticationPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BearerAuthenticationPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BearerAuthenticationPlanTypeJsonConverter))]
        public global::G.BearerAuthenticationPlanType Type { get; set; }

        /// <summary>
        /// This is the bearer token value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// This is the header name where the bearer token will be sent. Defaults to 'Authorization'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headerName")]
        public string? HeaderName { get; set; }

        /// <summary>
        /// Whether to include the 'Bearer ' prefix in the header value. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearerPrefixEnabled")]
        public bool? BearerPrefixEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BearerAuthenticationPlan" /> class.
        /// </summary>
        /// <param name="token">
        /// This is the bearer token value.
        /// </param>
        /// <param name="type"></param>
        /// <param name="headerName">
        /// This is the header name where the bearer token will be sent. Defaults to 'Authorization'.
        /// </param>
        /// <param name="bearerPrefixEnabled">
        /// Whether to include the 'Bearer ' prefix in the header value. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BearerAuthenticationPlan(
            string token,
            global::G.BearerAuthenticationPlanType type,
            string? headerName,
            bool? bearerPrefixEnabled)
        {
            this.Type = type;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.HeaderName = headerName;
            this.BearerPrefixEnabled = bearerPrefixEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BearerAuthenticationPlan" /> class.
        /// </summary>
        public BearerAuthenticationPlan()
        {
        }
    }
}