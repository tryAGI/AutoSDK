//HintName: G.Models.VideoSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the video embedding and its start time. Each segment is between 2 and 10 seconds.
    /// </summary>
    public sealed partial class VideoSegment
    {
        /// <summary>
        /// An array of floating point numbers representing the embedding. You can use this array with cosine similarity for various downstream tasks. Note that the example response was truncated for brevity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("float")]
        public global::System.Collections.Generic.IList<double>? Float { get; set; }

        /// <summary>
        /// The start time in seconds from the beginning of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_offset_sec")]
        public double? StartOffsetSec { get; set; }

        /// <summary>
        /// The end time in seconds from the beginning of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_offset_sec")]
        public double? EndOffsetSec { get; set; }

        /// <summary>
        /// The type of the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_option")]
        public string? EmbeddingOption { get; set; }

        /// <summary>
        /// The scope of the video embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scope")]
        public string? EmbeddingScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegment" /> class.
        /// </summary>
        /// <param name="float">
        /// An array of floating point numbers representing the embedding. You can use this array with cosine similarity for various downstream tasks. Note that the example response was truncated for brevity.
        /// </param>
        /// <param name="startOffsetSec">
        /// The start time in seconds from the beginning of the file.
        /// </param>
        /// <param name="endOffsetSec">
        /// The end time in seconds from the beginning of the file.
        /// </param>
        /// <param name="embeddingOption">
        /// The type of the embedding.
        /// </param>
        /// <param name="embeddingScope">
        /// The scope of the video embedding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSegment(
            global::System.Collections.Generic.IList<double>? @float,
            double? startOffsetSec,
            double? endOffsetSec,
            string? embeddingOption,
            string? embeddingScope)
        {
            this.Float = @float;
            this.StartOffsetSec = startOffsetSec;
            this.EndOffsetSec = endOffsetSec;
            this.EmbeddingOption = embeddingOption;
            this.EmbeddingScope = embeddingScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegment" /> class.
        /// </summary>
        public VideoSegment()
        {
        }
    }
}