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
    }
}