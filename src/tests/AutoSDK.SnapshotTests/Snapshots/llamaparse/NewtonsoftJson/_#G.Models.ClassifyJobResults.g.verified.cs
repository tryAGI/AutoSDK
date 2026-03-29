//HintName: G.Models.ClassifyJobResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for the classify endpoint following AIP-132 pagination standard.
    /// </summary>
    public sealed partial class ClassifyJobResults
    {
        /// <summary>
        /// The list of items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FileClassification> Items { get; set; } = default!;

        /// <summary>
        /// A token, which can be sent as page_token to retrieve the next page. If this field is omitted, there are no subsequent pages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The total number of items available. This is only populated when specifically requested. The value may be an estimate and can be used for display purposes only.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_size")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyJobResults" /> class.
        /// </summary>
        /// <param name="items">
        /// The list of items.
        /// </param>
        /// <param name="nextPageToken">
        /// A token, which can be sent as page_token to retrieve the next page. If this field is omitted, there are no subsequent pages.
        /// </param>
        /// <param name="totalSize">
        /// The total number of items available. This is only populated when specifically requested. The value may be an estimate and can be used for display purposes only.
        /// </param>
        public ClassifyJobResults(
            global::System.Collections.Generic.IList<global::G.FileClassification> items,
            string? nextPageToken,
            int? totalSize)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyJobResults" /> class.
        /// </summary>
        public ClassifyJobResults()
        {
        }
    }
}