﻿//HintName: G.Models.GenerateStreamedResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamedResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        public global::G.GenerateStreamedResponseDiscriminatorEventType? EventType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamedResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        public GenerateStreamedResponseDiscriminator(
            global::G.GenerateStreamedResponseDiscriminatorEventType? eventType)
        {
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamedResponseDiscriminator" /> class.
        /// </summary>
        public GenerateStreamedResponseDiscriminator()
        {
        }
    }
}