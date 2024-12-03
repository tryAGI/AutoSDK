//HintName: G.Models.AuditLogActor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The actor who performed the audit logged action.
    /// </summary>
    public sealed partial class AuditLogActor
    {
        /// <summary>
        /// The type of actor. Is either `session` or `api_key`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AuditLogActorType? Type { get; set; }

        /// <summary>
        /// The session in which the audit logged action was performed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session")]
        public global::G.AuditLogActorSession? Session { get; set; }

        /// <summary>
        /// The API Key used to perform the audit logged action.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public global::G.AuditLogActorApiKey? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActor" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of actor. Is either `session` or `api_key`.
        /// </param>
        /// <param name="session">
        /// The session in which the audit logged action was performed.
        /// </param>
        /// <param name="apiKey">
        /// The API Key used to perform the audit logged action.
        /// </param>
        public AuditLogActor(
            global::G.AuditLogActorType? type,
            global::G.AuditLogActorSession? session,
            global::G.AuditLogActorApiKey? apiKey)
        {
            this.Type = type;
            this.Session = session;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActor" /> class.
        /// </summary>
        public AuditLogActor()
        {
        }
    }
}