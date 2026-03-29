//HintName: G.Models.ItemProcessingResultsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing all processing results for an item.
    /// </summary>
    public sealed partial class ItemProcessingResultsResponse
    {
        /// <summary>
        /// ID of the source item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Name of the source item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemName { get; set; }

        /// <summary>
        /// List of all processing operations performed on this item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_results")]
        public global::System.Collections.Generic.IList<global::G.ProcessingResult>? ProcessingResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemProcessingResultsResponse" /> class.
        /// </summary>
        /// <param name="itemId">
        /// ID of the source item
        /// </param>
        /// <param name="itemName">
        /// Name of the source item
        /// </param>
        /// <param name="processingResults">
        /// List of all processing operations performed on this item
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemProcessingResultsResponse(
            string itemId,
            string itemName,
            global::System.Collections.Generic.IList<global::G.ProcessingResult>? processingResults)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.ItemName = itemName ?? throw new global::System.ArgumentNullException(nameof(itemName));
            this.ProcessingResults = processingResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemProcessingResultsResponse" /> class.
        /// </summary>
        public ItemProcessingResultsResponse()
        {
        }
    }
}