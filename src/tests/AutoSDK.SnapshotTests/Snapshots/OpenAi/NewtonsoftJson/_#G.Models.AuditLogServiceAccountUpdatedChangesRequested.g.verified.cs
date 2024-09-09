//HintName: G.Models.AuditLogServiceAccountUpdatedChangesRequested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to updated the service account.
    /// </summary>
    public sealed partial class AuditLogServiceAccountUpdatedChangesRequested
    {
        /// <summary>
        /// The role of the service account. Is either `owner` or `member`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}