//HintName: G.Models.CreateEventRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEventRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEventRequestEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateEventRequestEventType EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventRequest" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEventRequest(
            global::G.CreateEventRequestEventType eventType,
            string owner,
            string repo,
            string? commit)
        {
            this.EventType = eventType;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Commit = commit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventRequest" /> class.
        /// </summary>
        public CreateEventRequest()
        {
        }
    }
}