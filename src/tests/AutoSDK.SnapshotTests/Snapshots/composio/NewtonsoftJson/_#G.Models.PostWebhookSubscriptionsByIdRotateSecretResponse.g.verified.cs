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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// New signing secret
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string Secret { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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