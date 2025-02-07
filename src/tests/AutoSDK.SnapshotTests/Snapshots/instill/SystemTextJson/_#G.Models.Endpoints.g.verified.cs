//HintName: G.Models.Endpoints.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Endpoints describe the endpoints of a pipeline.
    /// </summary>
    public sealed partial class Endpoints
    {
        /// <summary>
        /// Webhook endpoints.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::System.Collections.Generic.Dictionary<string, global::G.WebhookEndpoint>? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoints" /> class.
        /// </summary>
        /// <param name="webhooks">
        /// Webhook endpoints.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Endpoints(
            global::System.Collections.Generic.Dictionary<string, global::G.WebhookEndpoint>? webhooks)
        {
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Endpoints" /> class.
        /// </summary>
        public Endpoints()
        {
        }
    }
}