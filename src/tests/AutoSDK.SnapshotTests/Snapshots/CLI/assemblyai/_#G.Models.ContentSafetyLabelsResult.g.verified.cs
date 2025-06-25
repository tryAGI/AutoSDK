﻿//HintName: G.Models.ContentSafetyLabelsResult.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioIntelligenceModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AudioIntelligenceModelStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ContentSafetyLabelResult> Results { get; set; }

        /// <summary>
        /// A summary of the Content Moderation confidence results for the entire audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Summary { get; set; }

        /// <summary>
        /// A summary of the Content Moderation severity results for the entire audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_score_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.SeverityScoreSummary> SeverityScoreSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSafetyLabelsResult" /> class.
        /// </summary>
        /// <param name="status">
        /// Either success, or unavailable in the rare case that the model failed
        /// </param>
        /// <param name="results"></param>
        /// <param name="summary">
        /// A summary of the Content Moderation confidence results for the entire audio file
        /// </param>
        /// <param name="severityScoreSummary">
        /// A summary of the Content Moderation severity results for the entire audio file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentSafetyLabelsResult(
            global::G.AudioIntelligenceModelStatus status,
            global::System.Collections.Generic.IList<global::G.ContentSafetyLabelResult> results,
            global::System.Collections.Generic.Dictionary<string, double> summary,
            global::System.Collections.Generic.Dictionary<string, global::G.SeverityScoreSummary> severityScoreSummary)
        {
            this.Status = status;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.SeverityScoreSummary = severityScoreSummary ?? throw new global::System.ArgumentNullException(nameof(severityScoreSummary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSafetyLabelsResult" /> class.
        /// </summary>
        public ContentSafetyLabelsResult()
        {
        }
    }
}