//HintName: G.Models.GetTriggersTypesBySlugResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTriggersTypesBySlugResponse
    {
        /// <summary>
        /// Unique identifier for the trigger type<br/>
        /// Example: SLACK_NEW_MESSAGE
        /// </summary>
        /// <example>SLACK_NEW_MESSAGE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Human-readable name of the trigger<br/>
        /// Example: New Message in Slack Channel
        /// </summary>
        /// <example>New Message in Slack Channel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Detailed description of what the trigger does<br/>
        /// Example: Triggers when a new message is posted to a Slack channel
        /// </summary>
        /// <example>Triggers when a new message is posted to a Slack channel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Step-by-step instructions on how to set up and use this trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// The trigger mechanism - either webhook (event-based) or poll (scheduled check)<br/>
        /// Example: webhook
        /// </summary>
        /// <example>webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetTriggersTypesBySlugResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetTriggersTypesBySlugResponseType Type { get; set; }

        /// <summary>
        /// Information about the toolkit that provides this trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetTriggersTypesBySlugResponseToolkit Toolkit { get; set; }

        /// <summary>
        /// Configuration schema required to set up this trigger<br/>
        /// Example: {"channel_id":{"type":"string","required":true},"message_type":{"type":"enum","options":["all","direct","channel"]}}
        /// </summary>
        /// <example>{"channel_id":{"type":"string","required":true},"message_type":{"type":"enum","options":["all","direct","channel"]}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Config { get; set; }

        /// <summary>
        /// Schema of the data payload this trigger will deliver when it fires<br/>
        /// Example: {"message":{"type":"string"},"sender":{"type":"object","properties":{"id":"string","name":"string"}},"timestamp":{"type":"number"}}
        /// </summary>
        /// <example>{"message":{"type":"string"},"sender":{"type":"object","properties":{"id":"string","name":"string"}},"timestamp":{"type":"number"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Payload { get; set; }

        /// <summary>
        /// Version of the trigger type<br/>
        /// Example: 20250930_00
        /// </summary>
        /// <example>20250930_00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggersTypesBySlugResponse" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTriggersTypesBySlugResponse(
            string slug,
            string name,
            string description,
            string instructions,
            global::G.GetTriggersTypesBySlugResponseType type,
            global::G.GetTriggersTypesBySlugResponseToolkit toolkit,
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
        /// Initializes a new instance of the <see cref="GetTriggersTypesBySlugResponse" /> class.
        /// </summary>
        public GetTriggersTypesBySlugResponse()
        {
        }
    }
}