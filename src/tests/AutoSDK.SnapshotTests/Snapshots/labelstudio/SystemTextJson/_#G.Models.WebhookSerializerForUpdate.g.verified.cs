//HintName: G.Models.WebhookSerializerForUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer class for updating webhooks<br/>
    /// Used to forbid updating project field.
    /// </summary>
    public sealed partial class WebhookSerializerForUpdate
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::G.ActionsEnum>? Actions { get; set; }

        /// <summary>
        /// Creation time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Key Value Json of headers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// If value is False the webhook is disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int Organization { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

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
        /// Last update time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="WebhookSerializerForUpdate" /> class.
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
        /// <param name="project">
        /// Included only in responses
        /// </param>
        /// <param name="sendForAllActions">
        /// If value is False - used only for actions from WebhookAction
        /// </param>
        /// <param name="sendPayload">
        /// If value is False send only action
        /// </param>
        /// <param name="createdAt">
        /// Creation time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Last update time<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSerializerForUpdate(
            string url,
            global::System.Collections.Generic.IList<global::G.ActionsEnum>? actions,
            object? headers,
            bool? isActive,
            int? project,
            bool? sendForAllActions,
            bool? sendPayload,
            global::System.DateTime createdAt = default!,
            int id = default!,
            int organization = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Actions = actions;
            this.CreatedAt = createdAt;
            this.Headers = headers;
            this.Id = id;
            this.IsActive = isActive;
            this.Organization = organization;
            this.Project = project;
            this.SendForAllActions = sendForAllActions;
            this.SendPayload = sendPayload;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSerializerForUpdate" /> class.
        /// </summary>
        public WebhookSerializerForUpdate()
        {
        }
    }
}