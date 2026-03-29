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
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// Name of the source item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemName { get; set; } = default!;

        /// <summary>
        /// List of all processing operations performed on this item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processing_results")]
        public global::System.Collections.Generic.IList<global::G.ProcessingResult>? ProcessingResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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