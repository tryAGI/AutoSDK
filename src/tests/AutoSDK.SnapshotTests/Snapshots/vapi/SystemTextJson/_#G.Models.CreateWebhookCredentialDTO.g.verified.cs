//HintName: G.Models.CreateWebhookCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebhookCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateWebhookCredentialDTOProviderJsonConverter))]
        public global::G.CreateWebhookCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthenticationPlan2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthenticationPlan2 AuthenticationPlan { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateWebhookCredentialDTO" /> class.
        /// </summary>
        /// <param name="authenticationPlan">
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebhookCredentialDTO(
            global::G.AuthenticationPlan2 authenticationPlan,
            global::G.CreateWebhookCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.AuthenticationPlan = authenticationPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookCredentialDTO" /> class.
        /// </summary>
        public CreateWebhookCredentialDTO()
        {
        }
    }
}