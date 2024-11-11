//HintName: G.Models.AppsCreateFromManifestResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsCreateFromManifestResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? WebhookSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsCreateFromManifestResponse2" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="webhookSecret"></param>
        /// <param name="pem"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AppsCreateFromManifestResponse2(
            string clientId,
            string clientSecret,
            string? webhookSecret,
            string pem)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.WebhookSecret = webhookSecret ?? throw new global::System.ArgumentNullException(nameof(webhookSecret));
            this.Pem = pem ?? throw new global::System.ArgumentNullException(nameof(pem));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsCreateFromManifestResponse2" /> class.
        /// </summary>
        public AppsCreateFromManifestResponse2()
        {
        }
    }
}