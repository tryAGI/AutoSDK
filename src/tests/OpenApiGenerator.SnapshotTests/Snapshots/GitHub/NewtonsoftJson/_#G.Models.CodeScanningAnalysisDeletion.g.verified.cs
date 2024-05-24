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
        /// Next deletable analysis in chain, without last analysis deletion confirmation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_analysis_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? NextAnalysisUrl { get; set; } = default!;

        /// <summary>
        /// Next deletable analysis in chain, with last analysis deletion confirmation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confirm_delete_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ConfirmDeleteUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}