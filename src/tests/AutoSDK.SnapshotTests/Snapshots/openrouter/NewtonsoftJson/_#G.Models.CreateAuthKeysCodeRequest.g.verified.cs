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
        [global::Newtonsoft.Json.JsonProperty("callback_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallbackUrl { get; set; } = default!;

        /// <summary>
        /// PKCE code challenge for enhanced security
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_challenge")]
        public string? CodeChallenge { get; set; }

        /// <summary>
        /// The method used to generate the code challenge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_challenge_method")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodJsonConverter))]
        public global::G.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod? CodeChallengeMethod { get; set; }

        /// <summary>
        /// Credit limit for the API key to be created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Optional expiration time for the API key to be created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Optional custom label for the API key. Defaults to the app name if not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_label")]
        public string? KeyLabel { get; set; }

        /// <summary>
        /// Optional credit limit reset interval. When set, the credit limit resets on this interval.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_limit_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitTypeJsonConverter))]
        public global::G.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitType? UsageLimitType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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