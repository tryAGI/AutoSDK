//HintName: G.Models.GuardResultsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardResultsResponse
    {
        /// <summary>
        /// Whether the content was flagged by any active detector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// Per-category flagging results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::G.Categories? Categories { get; set; }

        /// <summary>
        /// Detailed results from each detector that ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DetectorResult> Results { get; set; }

        /// <summary>
        /// Per-message breakdown with detailed results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        public global::System.Collections.Generic.IList<global::G.DetailedMessageBreakdown>? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardResultsResponse" /> class.
        /// </summary>
        /// <param name="flagged">
        /// Whether the content was flagged by any active detector.
        /// </param>
        /// <param name="results">
        /// Detailed results from each detector that ran.
        /// </param>
        /// <param name="categories">
        /// Per-category flagging results.
        /// </param>
        /// <param name="breakdown">
        /// Per-message breakdown with detailed results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardResultsResponse(
            bool flagged,
            global::System.Collections.Generic.IList<global::G.DetectorResult> results,
            global::G.Categories? categories,
            global::System.Collections.Generic.IList<global::G.DetailedMessageBreakdown>? breakdown)
        {
            this.Flagged = flagged;
            this.Categories = categories;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardResultsResponse" /> class.
        /// </summary>
        public GuardResultsResponse()
        {
        }
    }
}