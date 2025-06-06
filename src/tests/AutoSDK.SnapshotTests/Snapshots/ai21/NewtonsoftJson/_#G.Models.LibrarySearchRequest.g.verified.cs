﻿//HintName: G.Models.LibrarySearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class LibrarySearchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

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
        public global::G.LibrarySearchRequestLabelsFilterMode? LabelsFilterMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? FileIds { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrievalStrategy")]
        public global::G.RetrievalStrategy? RetrievalStrategy { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxNeighbors")]
        public int? MaxNeighbors { get; set; }

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
        /// Initializes a new instance of the <see cref="LibrarySearchRequest" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="maxSegments"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="labelsFilter"></param>
        /// <param name="labelsFilterMode">
        /// Default Value: AND
        /// </param>
        /// <param name="fileIds"></param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="maxNeighbors">
        /// Default Value: 1
        /// </param>
        /// <param name="retrievalSimilarityThreshold"></param>
        /// <param name="hybridSearchAlpha"></param>
        public LibrarySearchRequest(
            string query,
            int? maxSegments,
            string? path,
            global::System.Collections.Generic.IList<string>? labels,
            global::G.QueryFilter? labelsFilter,
            global::G.LibrarySearchRequestLabelsFilterMode? labelsFilterMode,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds,
            global::G.RetrievalStrategy? retrievalStrategy,
            int? maxNeighbors,
            double? retrievalSimilarityThreshold,
            double? hybridSearchAlpha)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.MaxSegments = maxSegments;
            this.Path = path;
            this.Labels = labels;
            this.LabelsFilter = labelsFilter;
            this.LabelsFilterMode = labelsFilterMode;
            this.FileIds = fileIds;
            this.RetrievalStrategy = retrievalStrategy;
            this.MaxNeighbors = maxNeighbors;
            this.RetrievalSimilarityThreshold = retrievalSimilarityThreshold;
            this.HybridSearchAlpha = hybridSearchAlpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibrarySearchRequest" /> class.
        /// </summary>
        public LibrarySearchRequest()
        {
        }
    }
}