//HintName: G.Models.CreateAuthKeysCodeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAuthKeysCodeRequest
    {
        /// <summary>
        /// The callback URL to redirect to after authorization. Note, only https URLs on ports 443 and 3000 are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallbackUrl { get; set; }

        /// <summary>
        /// PKCE code challenge for enhanced security
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge")]
        public string? CodeChallenge { get; set; }

        /// <summary>
        /// The method used to generate the code challenge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodJsonConverter))]
        public global::G.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod? CodeChallengeMethod { get; set; }

        /// <summary>
        /// Credit limit for the API key to be created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Optional expiration time for the API key to be created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Optional custom label for the API key. Defaults to the app name if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_label")]
        public string? KeyLabel { get; set; }

        /// <summary>
        /// Optional credit limit reset interval. When set, the credit limit resets on this interval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limit_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitTypeJsonConverter))]
        public global::G.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType? UsageLimitType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuthKeysCodeRequest" /> class.
        /// </summary>
        /// <param name="callbackUrl">
        /// The callback URL to redirect to after authorization. Note, only https URLs on ports 443 and 3000 are allowed.
        /// </param>
        /// <param name="codeChallenge">
        /// PKCE code challenge for enhanced security
        /// </param>
        /// <param name="codeChallengeMethod">
        /// The method used to generate the code challenge
        /// </param>
        /// <param name="limit">
        /// Credit limit for the API key to be created
        /// </param>
        /// <param name="expiresAt">
        /// Optional expiration time for the API key to be created
        /// </param>
        /// <param name="keyLabel">
        /// Optional custom label for the API key. Defaults to the app name if not provided.
        /// </param>
        /// <param name="usageLimitType">
        /// Optional credit limit reset interval. When set, the credit limit resets on this interval.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAuthKeysCodeRequest(
            string callbackUrl,
            string? codeChallenge,
            global::G.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod? codeChallengeMethod,
            double? limit,
            global::System.DateTime? expiresAt,
            string? keyLabel,
            global::G.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType? usageLimitType)
        {
            this.CallbackUrl = callbackUrl ?? throw new global::System.ArgumentNullException(nameof(callbackUrl));
            this.CodeChallenge = codeChallenge;
            this.CodeChallengeMethod = codeChallengeMethod;
            this.Limit = limit;
            this.ExpiresAt = expiresAt;
            this.KeyLabel = keyLabel;
            this.UsageLimitType = usageLimitType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuthKeysCodeRequest" /> class.
        /// </summary>
        public CreateAuthKeysCodeRequest()
        {
        }
    }
}