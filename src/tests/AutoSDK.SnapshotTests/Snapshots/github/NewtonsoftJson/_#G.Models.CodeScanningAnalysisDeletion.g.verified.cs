//HintName: G.Models.CodeScanningAnalysisDeletion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Successful deletion of a code scanning analysis
    /// </summary>
    public sealed partial class CodeScanningAnalysisDeletion
    {
        /// <summary>
        /// Next deletable analysis in chain, without last analysis deletion confirmation<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_analysis_url")]
        public string? NextAnalysisUrl { get; set; }

        /// <summary>
        /// Next deletable analysis in chain, with last analysis deletion confirmation<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confirm_delete_url")]
        public string? ConfirmDeleteUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAnalysisDeletion" /> class.
        /// </summary>
        /// <param name="nextAnalysisUrl">
        /// Next deletable analysis in chain, without last analysis deletion confirmation<br/>
        /// Included only in responses
        /// </param>
        /// <param name="confirmDeleteUrl">
        /// Next deletable analysis in chain, with last analysis deletion confirmation<br/>
        /// Included only in responses
        /// </param>
        public CodeScanningAnalysisDeletion(
            string? nextAnalysisUrl,
            string? confirmDeleteUrl)
        {
            this.NextAnalysisUrl = nextAnalysisUrl;
            this.ConfirmDeleteUrl = confirmDeleteUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAnalysisDeletion" /> class.
        /// </summary>
        public CodeScanningAnalysisDeletion()
        {
        }
    }
}