//HintName: G.Models.UpdateCustomLLMCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomLLMCredentialDTO
    {
        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// This is the authentication plan. Currently supports OAuth2 RFC 6749. To use Bearer authentication, use apiKey
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationPlan")]
        public global::G.OAuth2AuthenticationPlan? AuthenticationPlan { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomLLMCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="authenticationPlan">
        /// This is the authentication plan. Currently supports OAuth2 RFC 6749. To use Bearer authentication, use apiKey
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomLLMCredentialDTO(
            string? apiKey,
            global::G.OAuth2AuthenticationPlan? authenticationPlan,
            string? name)
        {
            this.ApiKey = apiKey;
            this.AuthenticationPlan = authenticationPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomLLMCredentialDTO" /> class.
        /// </summary>
        public UpdateCustomLLMCredentialDTO()
        {
        }
    }
}