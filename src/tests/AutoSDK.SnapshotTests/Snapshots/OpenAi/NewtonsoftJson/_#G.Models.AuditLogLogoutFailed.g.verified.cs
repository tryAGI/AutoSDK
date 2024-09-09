//HintName: G.Models.AuditLogLogoutFailed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogLogoutFailed
    {
        /// <summary>
        /// The error code of the failure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// The error message of the failure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}