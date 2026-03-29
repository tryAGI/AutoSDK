//HintName: G.Models.DeleteWebhookResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteWebhookResponse
    {
        /// <summary>
        /// Example: Webhook deleted successfully
        /// </summary>
        /// <example>Webhook deleted successfully</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWebhookResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Webhook deleted successfully
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteWebhookResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWebhookResponse" /> class.
        /// </summary>
        public DeleteWebhookResponse()
        {
        }
    }
}