//HintName: G.Models.WebhookRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRequest
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int? Project { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRequest" /> class.
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
        /// <param name="project"></param>
        /// <param name="sendForAllActions">
        /// If value is False - used only for actions from WebhookAction
        /// </param>
        /// <param name="sendPayload">
        /// If value is False send only action
        /// </param>
        public WebhookRequest(
            string url,
            global::System.Collections.Generic.IList<global::G.ActionsEnum>? actions,
            object? headers,
            bool? isActive,
            int? project,
            bool? sendForAllActions,
            bool? sendPayload)
        {
            this.Actions = actions;
            this.Headers = headers;
            this.IsActive = isActive;
            this.Project = project;
            this.SendForAllActions = sendForAllActions;
            this.SendPayload = sendPayload;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRequest" /> class.
        /// </summary>
        public WebhookRequest()
        {
        }
    }
}