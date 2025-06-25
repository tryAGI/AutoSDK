//HintName: G.Models.BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost
    {
        /// <summary>
        /// Transcribe this specific list of segments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost" /> class.
        /// </summary>
        /// <param name="segments">
        /// Transcribe this specific list of segments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost(
            global::System.Collections.Generic.IList<string> segments)
        {
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost" /> class.
        /// </summary>
        public BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost()
        {
        }
    }
}