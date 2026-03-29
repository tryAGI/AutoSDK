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
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The code verifier if code_challenge was used in the authorization request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_verifier")]
        public string? CodeVerifier { get; set; }

        /// <summary>
        /// The method used to generate the code challenge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod?, object>))]
        public global::G.OneOf<global::G.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethod?, object>? CodeChallengeMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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