//HintName: G.Models.Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event
    /// </summary>
    public sealed partial class Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Type { get; set; } = default!;

        /// <summary>
        /// Actor
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Actor Actor { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EventRepo Repo { get; set; } = default!;

        /// <summary>
        /// Actor
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org")]
        public global::G.Actor? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EventPayload Payload { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="actor">
        /// Actor
        /// </param>
        /// <param name="repo"></param>
        /// <param name="org">
        /// Actor
        /// </param>
        /// <param name="payload"></param>
        /// <param name="public"></param>
        /// <param name="createdAt"></param>
        public Event(
            string id,
            string? type,
            global::G.Actor actor,
            global::G.EventRepo repo,
            global::G.EventPayload payload,
            bool @public,
            global::System.DateTime? createdAt,
            global::G.Actor? org)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Public = @public;
            this.CreatedAt = createdAt;
            this.Org = org;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        public Event()
        {
        }
    }
}