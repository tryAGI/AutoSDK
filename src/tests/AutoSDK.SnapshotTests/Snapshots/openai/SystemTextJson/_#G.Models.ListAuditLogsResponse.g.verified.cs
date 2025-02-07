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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ListAuditLogsResponseObjectJsonConverter))]
        public global::G.ListAuditLogsResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AuditLog> Data { get; set; }

        /// <summary>
        /// Example: audit_log-defb456h8dks
        /// </summary>
        /// <example>audit_log-defb456h8dks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// Example: audit_log-hnbkd8s93s
        /// </summary>
        /// <example>audit_log-hnbkd8s93s</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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