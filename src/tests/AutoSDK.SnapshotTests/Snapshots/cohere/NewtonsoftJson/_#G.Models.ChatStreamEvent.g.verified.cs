﻿//HintName: G.Models.ChatStreamEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatStreamEventEventType EventType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEvent" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        public ChatStreamEvent(
            global::G.ChatStreamEventEventType eventType)
        {
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamEvent" /> class.
        /// </summary>
        public ChatStreamEvent()
        {
        }
    }
}