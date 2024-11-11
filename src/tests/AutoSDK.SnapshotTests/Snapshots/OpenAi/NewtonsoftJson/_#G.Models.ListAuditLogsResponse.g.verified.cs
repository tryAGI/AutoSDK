//HintName: G.Models.ListAuditLogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAuditLogsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ListAuditLogsResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AuditLog> Data { get; set; } = default!;

        /// <summary>
        /// Example: audit_log-defb456h8dks
        /// </summary>
        /// <example>audit_log-defb456h8dks</example>
        [global::Newtonsoft.Json.JsonProperty("first_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstId { get; set; } = default!;

        /// <summary>
        /// Example: audit_log-hnbkd8s93s
        /// </summary>
        /// <example>audit_log-hnbkd8s93s</example>
        [global::Newtonsoft.Json.JsonProperty("last_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuditLogsResponse" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="data"></param>
        /// <param name="firstId">
        /// Example: audit_log-defb456h8dks
        /// </param>
        /// <param name="lastId">
        /// Example: audit_log-hnbkd8s93s
        /// </param>
        /// <param name="hasMore"></param>
        public ListAuditLogsResponse(
            global::System.Collections.Generic.IList<global::G.AuditLog> data,
            string firstId,
            string lastId,
            bool hasMore,
            global::G.ListAuditLogsResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.HasMore = hasMore;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuditLogsResponse" /> class.
        /// </summary>
        public ListAuditLogsResponse()
        {
        }
    }
}