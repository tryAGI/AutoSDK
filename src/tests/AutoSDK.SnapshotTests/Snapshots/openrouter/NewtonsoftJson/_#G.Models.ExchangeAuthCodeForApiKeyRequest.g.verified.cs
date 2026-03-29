//HintName: G.Models.ExchangeAuthCodeForApiKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExchangeAuthCodeForApiKeyRequest
    {
        /// <summary>
        /// The authorization code received from the OAuth redirect
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// The code verifier if code_challenge was used in the authorization request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_verifier")]
        public string? CodeVerifier { get; set; }

        /// <summary>
        /// The method used to generate the code challenge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_challenge_method")]
        public global::G.OneOf<global::G.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod?, object>? CodeChallengeMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeAuthCodeForApiKeyRequest" /> class.
        /// </summary>
        /// <param name="code">
        /// The authorization code received from the OAuth redirect
        /// </param>
        /// <param name="codeVerifier">
        /// The code verifier if code_challenge was used in the authorization request
        /// </param>
        /// <param name="codeChallengeMethod">
        /// The method used to generate the code challenge
        /// </param>
        public ExchangeAuthCodeForApiKeyRequest(
            string code,
            string? codeVerifier,
            global::G.OneOf<global::G.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod?, object>? codeChallengeMethod)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.CodeVerifier = codeVerifier;
            this.CodeChallengeMethod = codeChallengeMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeAuthCodeForApiKeyRequest" /> class.
        /// </summary>
        public ExchangeAuthCodeForApiKeyRequest()
        {
        }
    }
}