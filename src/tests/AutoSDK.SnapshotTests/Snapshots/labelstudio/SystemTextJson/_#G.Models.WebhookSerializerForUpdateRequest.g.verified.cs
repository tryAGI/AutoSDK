//HintName: G.Models.WebhookSerializerForUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer class for updating webhooks<br/>
    /// Used to forbid updating project field.
    /// </summary>
    public sealed partial class WebhookSerializerForUpdateRequest
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::G.ActionsEnum>? Actions { get; set; }

        /// <summary>
        /// Key Value Json of headers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// If value is False the webhook is disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// If value is False - used only for actions from WebhookAction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_for_all_actions")]
        public bool? SendForAllActions { get; set; }

        /// <summary>
        /// If value is False send only action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_payload")]
        public bool? SendPayload { get; set; }

        /// <summary>
        /// URL of webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSerializerForUpdateRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of webhook
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSerializerForUpdateRequest(
            string url,
            global::System.Collections.Generic.IList<global::G.ActionsEnum>? actions,
            object? headers,
            bool? isActive,
            bool? sendForAllActions,
            bool? sendPayload)
        {
            this.Actions = actions;
            this.Headers = headers;
            this.IsActive = isActive;
            this.SendForAllActions = sendForAllActions;
            this.SendPayload = sendPayload;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSerializerForUpdateRequest" /> class.
        /// </summary>
        public WebhookSerializerForUpdateRequest()
        {
        }
    }
}