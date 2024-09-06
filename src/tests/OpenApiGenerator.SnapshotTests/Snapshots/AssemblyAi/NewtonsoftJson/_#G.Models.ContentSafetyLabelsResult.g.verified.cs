//HintName: G.Models.ContentSafetyLabelsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of results for the Content Moderation model, if it is enabled.<br/>
    /// See [Content moderation](https://www.assemblyai.com/docs/models/content-moderation) for more information.
    /// </summary>
    public sealed partial class ContentSafetyLabelsResult
    {
        /// <summary>
        /// Either success, or unavailable in the rare case that the model failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AudioIntelligenceModelStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContentSafetyLabelResult> Results { get; set; } = default!;

        /// <summary>
        /// A summary of the Content Moderation confidence results for the entire audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ContentSafetyLabelsResultSummary Summary { get; set; } = default!;

        /// <summary>
        /// A summary of the Content Moderation severity results for the entire audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity_score_summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ContentSafetyLabelsResultSeverityScoreSummary SeverityScoreSummary { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}