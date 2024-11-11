//HintName: G.Models.TimelineCrossReferencedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Timeline Cross Referenced Event
    /// </summary>
    public sealed partial class TimelineCrossReferencedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public string Event { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor")]
        public global::G.SimpleUser? Actor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TimelineCrossReferencedEventSource Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCrossReferencedEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="actor">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="source"></param>
        public TimelineCrossReferencedEvent(
            string @event,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.TimelineCrossReferencedEventSource source,
            global::G.SimpleUser? actor)
        {
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Actor = actor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCrossReferencedEvent" /> class.
        /// </summary>
        public TimelineCrossReferencedEvent()
        {
        }
    }
}