//HintName: G.Models.LibraryAnswerRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class LibraryAnswerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("question", Required = global::Newtonsoft.Json.Required.Always)]
        public string Question { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxSegments")]
        public int? MaxSegments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels_filter")]
        public global::G.QueryFilter? LabelsFilter { get; set; }

        /// <summary>
        /// Default Value: AND
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels_filter_mode")]
        public global::G.LibraryAnswerRequestLabelsFilterMode? LabelsFilterMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? FileIds { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answerLength")]
        public global::G.AnswerLength? AnswerLength { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.Mode? Mode { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrievalStrategy")]
        public global::G.RetrievalStrategy? RetrievalStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrievalSimilarityThreshold")]
        public double? RetrievalSimilarityThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hybridSearchAlpha")]
        public double? HybridSearchAlpha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryAnswerRequest" /> class.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="maxSegments"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="labelsFilter"></param>
        /// <param name="labelsFilterMode">
        /// Default Value: AND
        /// </param>
        /// <param name="fileIds"></param>
        /// <param name="answerLength">
        /// An enumeration.
        /// </param>
        /// <param name="mode">
        /// An enumeration.
        /// </param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="retrievalSimilarityThreshold"></param>
        /// <param name="hybridSearchAlpha"></param>
        public LibraryAnswerRequest(
            string question,
            int? maxSegments,
            string? path,
            global::System.Collections.Generic.IList<string>? labels,
            global::G.QueryFilter? labelsFilter,
            global::G.LibraryAnswerRequestLabelsFilterMode? labelsFilterMode,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds,
            global::G.AnswerLength? answerLength,
            global::G.Mode? mode,
            global::G.RetrievalStrategy? retrievalStrategy,
            double? retrievalSimilarityThreshold,
            double? hybridSearchAlpha)
        {
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.MaxSegments = maxSegments;
            this.Path = path;
            this.Labels = labels;
            this.LabelsFilter = labelsFilter;
            this.LabelsFilterMode = labelsFilterMode;
            this.FileIds = fileIds;
            this.AnswerLength = answerLength;
            this.Mode = mode;
            this.RetrievalStrategy = retrievalStrategy;
            this.RetrievalSimilarityThreshold = retrievalSimilarityThreshold;
            this.HybridSearchAlpha = hybridSearchAlpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryAnswerRequest" /> class.
        /// </summary>
        public LibraryAnswerRequest()
        {
        }
    }
}