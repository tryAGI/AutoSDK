//HintName: G.Models.DeleteWebhookResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteWebhookResponse2
    {
        /// <summary>
        /// Example: You don't have access to this webhook
        /// </summary>
        /// <example>You don't have access to this webhook</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWebhookResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: You don't have access to this webhook
        /// </param>
        public DeleteWebhookResponse2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWebhookResponse2" /> class.
        /// </summary>
        public DeleteWebhookResponse2()
        {
        }
    }
}