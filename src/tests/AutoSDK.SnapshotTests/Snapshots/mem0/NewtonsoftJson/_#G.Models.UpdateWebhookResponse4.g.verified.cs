//HintName: G.Models.UpdateWebhookResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWebhookResponse4
    {
        /// <summary>
        /// Example: Webhook not found
        /// </summary>
        /// <example>Webhook not found</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookResponse4" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Webhook not found
        /// </param>
        public UpdateWebhookResponse4(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookResponse4" /> class.
        /// </summary>
        public UpdateWebhookResponse4()
        {
        }
    }
}