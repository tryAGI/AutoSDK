//HintName: G.Models.PageDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the transcript page. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
    /// </summary>
    public sealed partial class PageDetails
    {
        /// <summary>
        /// The number of results this page is limited to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// The actual number of results in the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResultCount { get; set; }

        /// <summary>
        /// The URL used to retrieve the current page of transcripts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentUrl { get; set; }

        /// <summary>
        /// The URL to the next page of transcripts. The previous URL always points to a page with older transcripts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrevUrl { get; set; }

        /// <summary>
        /// The URL to the next page of transcripts. The next URL always points to a page with newer transcripts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}