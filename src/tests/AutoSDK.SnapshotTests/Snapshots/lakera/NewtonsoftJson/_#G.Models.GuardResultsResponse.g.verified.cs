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
        [global::Newtonsoft.Json.JsonProperty("flagged", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Flagged { get; set; } = default!;

        /// <summary>
        /// Per-category flagging results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories")]
        public global::G.Categories? Categories { get; set; }

        /// <summary>
        /// Detailed results from each detector that ran.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DetectorResult> Results { get; set; } = default!;

        /// <summary>
        /// Per-message breakdown with detailed results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("breakdown")]
        public global::System.Collections.Generic.IList<global::G.DetailedMessageBreakdown>? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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