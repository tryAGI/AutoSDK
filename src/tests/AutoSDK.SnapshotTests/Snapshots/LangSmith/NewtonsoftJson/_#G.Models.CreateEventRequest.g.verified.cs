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
        [global::Newtonsoft.Json.JsonProperty("event_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateEventRequestEventType EventType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo", Required = global::Newtonsoft.Json.Required.Always)]
        public string Repo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventRequest" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commit"></param>
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