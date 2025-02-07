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
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public global::G.SimpleUser? Actor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimelineCrossReferencedEventSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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