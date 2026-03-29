//HintName: G.Models.CreateProjectAutomationConfigVariant4ActionVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectAutomationConfigVariant4ActionVariant2
    {
        /// <summary>
        /// The type of action to take
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateProjectAutomationConfigVariant4ActionVariant2Type Type { get; set; }

        /// <summary>
        /// The Slack workspace ID to post to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkspaceId { get; set; } = default!;

        /// <summary>
        /// The Slack channel ID to post to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel", Required = global::Newtonsoft.Json.Required.Always)]
        public string Channel { get; set; } = default!;

        /// <summary>
        /// Custom message template for the alert
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_template")]
        public string? MessageTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant4ActionVariant2" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// The Slack workspace ID to post to
        /// </param>
        /// <param name="channel">
        /// The Slack channel ID to post to
        /// </param>
        /// <param name="type">
        /// The type of action to take
        /// </param>
        /// <param name="messageTemplate">
        /// Custom message template for the alert
        /// </param>
        public CreateProjectAutomationConfigVariant4ActionVariant2(
            string workspaceId,
            string channel,
            global::G.CreateProjectAutomationConfigVariant4ActionVariant2Type type,
            string? messageTemplate)
        {
            this.Type = type;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
            this.MessageTemplate = messageTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant4ActionVariant2" /> class.
        /// </summary>
        public CreateProjectAutomationConfigVariant4ActionVariant2()
        {
        }
    }
}