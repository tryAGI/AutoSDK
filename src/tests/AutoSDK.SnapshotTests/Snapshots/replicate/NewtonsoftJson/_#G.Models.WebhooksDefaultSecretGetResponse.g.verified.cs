//HintName: G.Models.WebhooksDefaultSecretGetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksDefaultSecretGetResponse
    {
        /// <summary>
        /// The signing secret.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksDefaultSecretGetResponse" /> class.
        /// </summary>
        /// <param name="key">
        /// The signing secret.
        /// </param>
        public WebhooksDefaultSecretGetResponse(
            string? key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksDefaultSecretGetResponse" /> class.
        /// </summary>
        public WebhooksDefaultSecretGetResponse()
        {
        }
    }
}