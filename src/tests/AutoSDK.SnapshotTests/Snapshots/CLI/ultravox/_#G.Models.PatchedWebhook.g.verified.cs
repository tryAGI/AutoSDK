//HintName: G.Models.PatchedWebhook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedWebhook
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookId")]
        public global::System.Guid? WebhookId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::G.EventsEnum>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedWebhook" /> class.
        /// </summary>
        /// <param name="webhookId">
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="url"></param>
        /// <param name="secrets"></param>
        /// <param name="events"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedWebhook(
            global::System.Guid? webhookId,
            global::System.DateTime? created,
            string? url,
            global::System.Collections.Generic.IList<string>? secrets,
            global::System.Collections.Generic.IList<global::G.EventsEnum>? events)
        {
            this.WebhookId = webhookId;
            this.Created = created;
            this.Url = url;
            this.Secrets = secrets;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedWebhook" /> class.
        /// </summary>
        public PatchedWebhook()
        {
        }
    }
}