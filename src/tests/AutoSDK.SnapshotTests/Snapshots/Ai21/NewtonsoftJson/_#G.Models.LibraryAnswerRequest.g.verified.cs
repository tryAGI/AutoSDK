//HintName: G.Models.LibraryAnswerRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        public int MaxSegments { get; set; }

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
        public global::G.AllOf<global::G.RetrievalStrategy3?>? RetrievalStrategy { get; set; } = global::G.RetrievalStrategy3.Default;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrievalSimilarityThreshold")]
        public double RetrievalSimilarityThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hybridSearchAlpha")]
        public double HybridSearchAlpha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}