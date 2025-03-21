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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The service account that performed the audit logged action.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account")]
        public global::G.AuditLogActorServiceAccount? ServiceAccount { get; set; }

        /// <summary>
        /// The type of API key. Can be either `user` or `service_account`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AuditLogActorApiKeyType? Type { get; set; }

        /// <summary>
        /// The user who performed the audit logged action.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.AuditLogActorUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// The tracking id of the API key.
        /// </param>
        /// <param name="serviceAccount">
        /// The service account that performed the audit logged action.
        /// </param>
        /// <param name="type">
        /// The type of API key. Can be either `user` or `service_account`.
        /// </param>
        /// <param name="user">
        /// The user who performed the audit logged action.
        /// </param>
        public AuditLogActorApiKey(
            string? id,
            global::G.AuditLogActorServiceAccount? serviceAccount,
            global::G.AuditLogActorApiKeyType? type,
            global::G.AuditLogActorUser? user)
        {
            this.Id = id;
            this.ServiceAccount = serviceAccount;
            this.Type = type;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorApiKey" /> class.
        /// </summary>
        public AuditLogActorApiKey()
        {
        }
    }
}