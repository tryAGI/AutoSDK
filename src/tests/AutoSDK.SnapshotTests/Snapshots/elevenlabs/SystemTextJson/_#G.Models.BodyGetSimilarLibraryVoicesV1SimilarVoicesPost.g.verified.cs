//HintName: G.Models.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyGetSimilarLibraryVoicesV1SimilarVoicesPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_file")]
        public byte[]? AudioFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_filename")]
        public string? AudioFilename { get; set; }

        /// <summary>
        /// Threshold for voice similarity between provided sample and library voices. Must be in range &lt;0, 2&gt;. The smaller the value the more similar voices will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_threshold")]
        public double? SimilarityThreshold { get; set; }

        /// <summary>
        /// Number of most similar voices to return. If similarity_threshold is provided, less than this number of voices may be returned. Must be in range &lt;1, 100&gt;.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGetSimilarLibraryVoicesV1SimilarVoicesPost" /> class.
        /// </summary>
        /// <param name="audioFile"></param>
        /// <param name="audioFilename"></param>
        /// <param name="similarityThreshold">
        /// Threshold for voice similarity between provided sample and library voices. Must be in range &lt;0, 2&gt;. The smaller the value the more similar voices will be returned.
        /// </param>
        /// <param name="topK">
        /// Number of most similar voices to return. If similarity_threshold is provided, less than this number of voices may be returned. Must be in range &lt;1, 100&gt;.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyGetSimilarLibraryVoicesV1SimilarVoicesPost(
            byte[]? audioFile,
            string? audioFilename,
            double? similarityThreshold,
            int? topK)
        {
            this.AudioFile = audioFile;
            this.AudioFilename = audioFilename;
            this.SimilarityThreshold = similarityThreshold;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGetSimilarLibraryVoicesV1SimilarVoicesPost" /> class.
        /// </summary>
        public BodyGetSimilarLibraryVoicesV1SimilarVoicesPost()
        {
        }
    }
}