//HintName: G.Models.UpdateWebhookCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWebhookCredentialDTO
    {
        /// <summary>
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthenticationPlan8JsonConverter))]
        public global::G.AuthenticationPlan8? AuthenticationPlan { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateWebhookCredentialDTO" /> class.
        /// </summary>
        /// <param name="authenticationPlan">
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWebhookCredentialDTO(
            global::G.AuthenticationPlan8? authenticationPlan,
            string? name)
        {
            this.AuthenticationPlan = authenticationPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookCredentialDTO" /> class.
        /// </summary>
        public UpdateWebhookCredentialDTO()
        {
        }
    }
}