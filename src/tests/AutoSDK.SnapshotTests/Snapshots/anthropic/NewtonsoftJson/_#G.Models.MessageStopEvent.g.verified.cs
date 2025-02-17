﻿//HintName: G.Models.MessageStopEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageStopEvent
    {
        /// <summary>
        /// Default Value: message_stop
        /// </summary>
        /// <default>global::G.MessageStopEventType.MessageStop</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageStopEventType Type { get; set; } = global::G.MessageStopEventType.MessageStop;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStopEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: message_stop
        /// </param>
        public MessageStopEvent(
            global::G.MessageStopEventType type = global::G.MessageStopEventType.MessageStop)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStopEvent" /> class.
        /// </summary>
        public MessageStopEvent()
        {
        }
    }
}