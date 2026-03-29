//HintName: G.Models.PatchedWebhookSerializerForUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer class for updating webhooks<br/>
    /// Used to forbid updating project field.
    /// </summary>
    public sealed partial class PatchedWebhookSerializerForUpdateRequest
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actions")]
        public global::System.Collections.Generic.IList<global::G.ActionsEnum>? Actions { get; set; }

        /// <summary>
        /// Key Value Json of headers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// If value is False the webhook is disabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// If value is False - used only for actions from WebhookAction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("send_for_all_actions")]
        public bool? SendForAllActions { get; set; }

        /// <summary>
        /// If value is False send only action
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("send_payload")]
        public bool? SendPayload { get; set; }

        /// <summary>
        /// URL of webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedWebhookSerializerForUpdateRequest" /> class.
        /// </summary>
        /// <param name="actions">
        /// Default Value: []
        /// </param>
        /// <param name="headers">
        /// Key Value Json of headers
        /// </param>
        /// <param name="isActive">
        /// If value is False the webhook is disabled
        /// </param>
        /// <param name="sendForAllActions">
        /// If value is False - used only for actions from WebhookAction
        /// </param>
        /// <param name="sendPayload">
        /// If value is False send only action
        /// </param>
        /// <param name="url">
        /// URL of webhook
        /// </param>
        public PatchedWebhookSerializerForUpdateRequest(
            global::System.Collections.Generic.IList<global::G.ActionsEnum>? actions,
            object? headers,
            bool? isActive,
            bool? sendForAllActions,
            bool? sendPayload,
            string? url)
        {
            this.Actions = actions;
            this.Headers = headers;
            this.IsActive = isActive;
            this.SendForAllActions = sendForAllActions;
            this.SendPayload = sendPayload;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedWebhookSerializerForUpdateRequest" /> class.
        /// </summary>
        public PatchedWebhookSerializerForUpdateRequest()
        {
        }
    }
}