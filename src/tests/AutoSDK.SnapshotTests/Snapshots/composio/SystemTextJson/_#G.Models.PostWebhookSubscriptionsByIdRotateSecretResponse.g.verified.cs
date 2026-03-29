//HintName: G.Models.PostWebhookSubscriptionsByIdRotateSecretResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostWebhookSubscriptionsByIdRotateSecretResponse
    {
        /// <summary>
        /// Subscription ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// New signing secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWebhookSubscriptionsByIdRotateSecretResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Subscription ID
        /// </param>
        /// <param name="secret">
        /// New signing secret
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostWebhookSubscriptionsByIdRotateSecretResponse(
            string id,
            string secret)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWebhookSubscriptionsByIdRotateSecretResponse" /> class.
        /// </summary>
        public PostWebhookSubscriptionsByIdRotateSecretResponse()
        {
        }
    }
}