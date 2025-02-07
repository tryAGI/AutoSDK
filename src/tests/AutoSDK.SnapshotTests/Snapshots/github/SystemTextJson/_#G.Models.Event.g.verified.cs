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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Type { get; set; }

        /// <summary>
        /// Actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Actor Actor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EventRepo Repo { get; set; }

        /// <summary>
        /// Actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public global::G.Actor? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EventPayload Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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