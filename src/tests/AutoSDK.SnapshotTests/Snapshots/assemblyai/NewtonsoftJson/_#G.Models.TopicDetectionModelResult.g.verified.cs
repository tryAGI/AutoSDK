﻿//HintName: G.Models.TopicDetectionModelResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the Topic Detection model, if it is enabled.<br/>
    /// See [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) for more information.
    /// </summary>
    public sealed partial class TopicDetectionModelResult
    {
        /// <summary>
        /// Either success, or unavailable in the rare case that the model failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AudioIntelligenceModelStatus Status { get; set; } = default!;

        /// <summary>
        /// An array of results for the Topic Detection model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TopicDetectionResult> Results { get; set; } = default!;

        /// <summary>
        /// The overall relevance of topic to the entire audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, double> Summary { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionModelResult" /> class.
        /// </summary>
        /// <param name="status">
        /// Either success, or unavailable in the rare case that the model failed
        /// </param>
        /// <param name="results">
        /// An array of results for the Topic Detection model
        /// </param>
        /// <param name="summary">
        /// The overall relevance of topic to the entire audio file
        /// </param>
        public TopicDetectionModelResult(
            global::G.AudioIntelligenceModelStatus status,
            global::System.Collections.Generic.IList<global::G.TopicDetectionResult> results,
            global::System.Collections.Generic.Dictionary<string, double> summary)
        {
            this.Status = status;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionModelResult" /> class.
        /// </summary>
        public TopicDetectionModelResult()
        {
        }
    }
}