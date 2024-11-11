//HintName: G.Models.AuditLogActorApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The API Key used to perform the audit logged action.
    /// </summary>
    public sealed partial class AuditLogActorApiKey
    {
        /// <summary>
        /// The tracking id of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of API key. Can be either `user` or `service_account`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuditLogActorApiKeyTypeJsonConverter))]
        public global::G.AuditLogActorApiKeyType? Type { get; set; }

        /// <summary>
        /// The user who performed the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.AuditLogActorUser? User { get; set; }

        /// <summary>
        /// The service account that performed the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account")]
        public global::G.AuditLogActorServiceAccount? ServiceAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// The tracking id of the API key.
        /// </param>
        /// <param name="type">
        /// The type of API key. Can be either `user` or `service_account`.
        /// </param>
        /// <param name="user">
        /// The user who performed the audit logged action.
        /// </param>
        /// <param name="serviceAccount">
        /// The service account that performed the audit logged action.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AuditLogActorApiKey(
            string? id,
            global::G.AuditLogActorApiKeyType? type,
            global::G.AuditLogActorUser? user,
            global::G.AuditLogActorServiceAccount? serviceAccount)
        {
            this.Id = id;
            this.Type = type;
            this.User = user;
            this.ServiceAccount = serviceAccount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorApiKey" /> class.
        /// </summary>
        public AuditLogActorApiKey()
        {
        }
    }
}