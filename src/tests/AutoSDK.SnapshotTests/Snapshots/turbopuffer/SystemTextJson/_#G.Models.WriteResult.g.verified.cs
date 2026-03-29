//HintName: G.Models.WriteResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response to a successful write request.
    /// </summary>
    public sealed partial class WriteResult
    {
        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <default>"OK"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "OK";

        /// <summary>
        /// A message describing the result of the write request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The number of rows affected by the write request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_affected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowsAffected { get; set; }

        /// <summary>
        /// The number of rows upserted by the write request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_upserted")]
        public int? RowsUpserted { get; set; }

        /// <summary>
        /// The number of rows patched by the write request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_patched")]
        public int? RowsPatched { get; set; }

        /// <summary>
        /// The number of rows deleted by the write request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_deleted")]
        public int? RowsDeleted { get; set; }

        /// <summary>
        /// Whether more documents match the filter for partial operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_remaining")]
        public bool? RowsRemaining { get; set; }

        /// <summary>
        /// The IDs of documents that were upserted. Only included when `return_affected_ids` is true and at least one document was upserted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upserted_ids")]
        public global::System.Collections.Generic.IList<global::G.Id>? UpsertedIds { get; set; }

        /// <summary>
        /// The IDs of documents that were patched. Only included when `return_affected_ids` is true and at least one document was patched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patched_ids")]
        public global::System.Collections.Generic.IList<global::G.Id>? PatchedIds { get; set; }

        /// <summary>
        /// The IDs of documents that were deleted. Only included when `return_affected_ids` is true and at least one document was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_ids")]
        public global::System.Collections.Generic.IList<global::G.Id>? DeletedIds { get; set; }

        /// <summary>
        /// The billing information for a write request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WriteBilling Billing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteResult" /> class.
        /// </summary>
        /// <param name="message">
        /// A message describing the result of the write request.
        /// </param>
        /// <param name="rowsAffected">
        /// The number of rows affected by the write request.
        /// </param>
        /// <param name="billing">
        /// The billing information for a write request.
        /// </param>
        /// <param name="rowsUpserted">
        /// The number of rows upserted by the write request.
        /// </param>
        /// <param name="rowsPatched">
        /// The number of rows patched by the write request.
        /// </param>
        /// <param name="rowsDeleted">
        /// The number of rows deleted by the write request.
        /// </param>
        /// <param name="rowsRemaining">
        /// Whether more documents match the filter for partial operations.
        /// </param>
        /// <param name="upsertedIds">
        /// The IDs of documents that were upserted. Only included when `return_affected_ids` is true and at least one document was upserted.
        /// </param>
        /// <param name="patchedIds">
        /// The IDs of documents that were patched. Only included when `return_affected_ids` is true and at least one document was patched.
        /// </param>
        /// <param name="deletedIds">
        /// The IDs of documents that were deleted. Only included when `return_affected_ids` is true and at least one document was deleted.
        /// </param>
        /// <param name="status">
        /// The status of the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WriteResult(
            string message,
            int rowsAffected,
            global::G.WriteBilling billing,
            int? rowsUpserted,
            int? rowsPatched,
            int? rowsDeleted,
            bool? rowsRemaining,
            global::System.Collections.Generic.IList<global::G.Id>? upsertedIds,
            global::System.Collections.Generic.IList<global::G.Id>? patchedIds,
            global::System.Collections.Generic.IList<global::G.Id>? deletedIds,
            string status = "OK")
        {
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RowsAffected = rowsAffected;
            this.RowsUpserted = rowsUpserted;
            this.RowsPatched = rowsPatched;
            this.RowsDeleted = rowsDeleted;
            this.RowsRemaining = rowsRemaining;
            this.UpsertedIds = upsertedIds;
            this.PatchedIds = patchedIds;
            this.DeletedIds = deletedIds;
            this.Billing = billing ?? throw new global::System.ArgumentNullException(nameof(billing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteResult" /> class.
        /// </summary>
        public WriteResult()
        {
        }
    }
}