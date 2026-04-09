//HintName: G.Models.GetTriggersTypesResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTriggersTypesResponseItem
    {
        /// <summary>
        /// Unique identifier for the trigger type<br/>
        /// Example: SLACK_NEW_MESSAGE
        /// </summary>
        /// <example>SLACK_NEW_MESSAGE</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Human-readable name of the trigger<br/>
        /// Example: New Message in Slack Channel
        /// </summary>
        /// <example>New Message in Slack Channel</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Detailed description of what the trigger does<br/>
        /// Example: Triggers when a new message is posted to a Slack channel
        /// </summary>
        /// <example>Triggers when a new message is posted to a Slack channel</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Step-by-step instructions on how to set up and use this trigger
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// The trigger mechanism - either webhook (event-based) or poll (scheduled check)<br/>
        /// Example: webhook
        /// </summary>
        /// <example>webhook</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetTriggersTypesResponseItemTypeJsonConverter))]
        public global::G.GetTriggersTypesResponseItemType Type { get; set; } = default!;

        /// <summary>
        /// Information about the toolkit that provides this trigger
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetTriggersTypesResponseItemToolkit Toolkit { get; set; } = default!;

        /// <summary>
        /// Configuration schema required to set up this trigger<br/>
        /// Example: {"channel_id":{"type":"string","required":true},"message_type":{"type":"enum","options":["all","direct","channel"]}}
        /// </summary>
        /// <example>{"channel_id":{"type":"string","required":true},"message_type":{"type":"enum","options":["all","direct","channel"]}}</example>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> Config { get; set; } = default!;

        /// <summary>
        /// Schema of the data payload this trigger will deliver when it fires<br/>
        /// Example: {"message":{"type":"string"},"sender":{"type":"object","properties":{"id":"string","name":"string"}},"timestamp":{"type":"number"}}
        /// </summary>
        /// <example>{"message":{"type":"string"},"sender":{"type":"object","properties":{"id":"string","name":"string"}},"timestamp":{"type":"number"}}</example>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> Payload { get; set; } = default!;

        /// <summary>
        /// Version of the trigger type<br/>
        /// Example: 20250930_00
        /// </summary>
        /// <example>20250930_00</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggersTypesResponseItem" /> class.
        /// </summary>
        /// <param name="slug">
        /// Unique identifier for the trigger type<br/>
        /// Example: SLACK_NEW_MESSAGE
        /// </param>
        /// <param name="name">
        /// Human-readable name of the trigger<br/>
        /// Example: New Message in Slack Channel
        /// </param>
        /// <param name="description">
        /// Detailed description of what the trigger does<br/>
        /// Example: Triggers when a new message is posted to a Slack channel
        /// </param>
        /// <param name="instructions">
        /// Step-by-step instructions on how to set up and use this trigger
        /// </param>
        /// <param name="type">
        /// The trigger mechanism - either webhook (event-based) or poll (scheduled check)<br/>
        /// Example: webhook
        /// </param>
        /// <param name="toolkit">
        /// Information about the toolkit that provides this trigger
        /// </param>
        /// <param name="config">
        /// Configuration schema required to set up this trigger<br/>
        /// Example: {"channel_id":{"type":"string","required":true},"message_type":{"type":"enum","options":["all","direct","channel"]}}
        /// </param>
        /// <param name="payload">
        /// Schema of the data payload this trigger will deliver when it fires<br/>
        /// Example: {"message":{"type":"string"},"sender":{"type":"object","properties":{"id":"string","name":"string"}},"timestamp":{"type":"number"}}
        /// </param>
        /// <param name="version">
        /// Version of the trigger type<br/>
        /// Example: 20250930_00
        /// </param>
        public GetTriggersTypesResponseItem(
            string slug,
            string name,
            string description,
            string instructions,
            global::G.GetTriggersTypesResponseItemType type,
            global::G.GetTriggersTypesResponseItemToolkit toolkit,
            global::System.Collections.Generic.Dictionary<string, object?> config,
            global::System.Collections.Generic.Dictionary<string, object?> payload,
            string version)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Type = type;
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggersTypesResponseItem" /> class.
        /// </summary>
        public GetTriggersTypesResponseItem()
        {
        }
    }
}