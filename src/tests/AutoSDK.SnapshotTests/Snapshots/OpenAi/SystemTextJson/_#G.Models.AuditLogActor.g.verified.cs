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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.AuditLogActorTypeJsonConverter))]
        public global::G.AuditLogActorType? Type { get; set; }

        /// <summary>
        /// The session in which the audit logged action was performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::G.AuditLogActorSession? Session { get; set; }

        /// <summary>
        /// The API Key used to perform the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::G.AuditLogActorApiKey? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}