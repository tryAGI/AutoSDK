//HintName: G.Models.AuditLogActorServiceAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The service account that performed the audit logged action.
    /// </summary>
    public sealed partial class AuditLogActorServiceAccount
    {
        /// <summary>
        /// The service account id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}