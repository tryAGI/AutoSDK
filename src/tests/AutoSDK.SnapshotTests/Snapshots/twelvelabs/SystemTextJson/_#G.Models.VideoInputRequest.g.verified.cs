//HintName: G.Models.VideoInputRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is required if the `input_type` parameter is `video`.
    /// </summary>
    public sealed partial class VideoInputRequest
    {
        /// <summary>
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MediaSource MediaSource { get; set; }

        /// <summary>
        /// The start time in seconds for processing the video file.<br/>
        /// Use this parameter to process a portion of the video file starting from a specific time.<br/>
        /// **Default**: 0 (start from the beginning)<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_sec")]
        public double? StartSec { get; set; }

        /// <summary>
        /// The end time in seconds for processing the video file.<br/>
        /// Use this parameter to process a portion of the video file ending at a specific time. The end time must be greater than the start time.<br/>
        /// **Default**: End of the video file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sec")]
        public double? EndSec { get; set; }

        /// <summary>
        /// Specifies how the platform divides the video into segments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VideoSegmentationJsonConverter))]
        public global::G.VideoSegmentation? Segmentation { get; set; }

        /// <summary>
        /// The types of embeddings to generate for the video.<br/>
        /// **Values:**<br/>
        /// - `visual`: Generates embeddings based on visual content (scenes, objects, actions)<br/>
        /// - `audio`: Generates embeddings based on audio content (sounds, music, effects)<br/>
        /// - `transcription`: Generates embeddings based on transcribed speech<br/>
        /// You can specify multiple options to generate different types of embeddings for the same video.<br/>
        /// **Default**: `["visual", "audio", "transcription"]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_option")]
        public global::System.Collections.Generic.IList<global::G.VideoInputRequestEmbeddingOptionItems>? EmbeddingOption { get; set; }

        /// <summary>
        /// The scope for which you wish to generate embeddings.<br/>
        /// **Values**:<br/>
        /// - `clip`: Generates one embedding for each segment<br/>
        /// - `asset`: Generates one embedding for the entire video file. Use this scope for videos up to 10-30 seconds to maintain optimal performance.<br/>
        /// You can specify multiple scopes to generate embeddings at different levels.<br/>
        /// **Default**: `["clip", "asset"]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scope")]
        public global::System.Collections.Generic.IList<global::G.VideoInputRequestEmbeddingScopeItems>? EmbeddingScope { get; set; }

        /// <summary>
        /// Specifies how to structure the embedding. Include this parameter only when `embedding_option` contains at least two values.<br/>
        /// **Values**:<br/>
        /// - `separate_embedding`: Returns separate embeddings per modality specified in `embedding_option`<br/>
        /// - `fused_embedding`: Returns a single embedding that combines all modalities into one vector<br/>
        /// Specify both values to receive separate and fused embeddings in the same response.<br/>
        /// **Default**: `separate_embedding`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        public global::System.Collections.Generic.IList<global::G.VideoInputRequestEmbeddingTypeItems>? EmbeddingType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoInputRequest" /> class.
        /// </summary>
        /// <param name="mediaSource">
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </param>
        /// <param name="startSec">
        /// The start time in seconds for processing the video file.<br/>
        /// Use this parameter to process a portion of the video file starting from a specific time.<br/>
        /// **Default**: 0 (start from the beginning)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="endSec">
        /// The end time in seconds for processing the video file.<br/>
        /// Use this parameter to process a portion of the video file ending at a specific time. The end time must be greater than the start time.<br/>
        /// **Default**: End of the video file
        /// </param>
        /// <param name="segmentation">
        /// Specifies how the platform divides the video into segments.
        /// </param>
        /// <param name="embeddingOption">
        /// The types of embeddings to generate for the video.<br/>
        /// **Values:**<br/>
        /// - `visual`: Generates embeddings based on visual content (scenes, objects, actions)<br/>
        /// - `audio`: Generates embeddings based on audio content (sounds, music, effects)<br/>
        /// - `transcription`: Generates embeddings based on transcribed speech<br/>
        /// You can specify multiple options to generate different types of embeddings for the same video.<br/>
        /// **Default**: `["visual", "audio", "transcription"]`
        /// </param>
        /// <param name="embeddingScope">
        /// The scope for which you wish to generate embeddings.<br/>
        /// **Values**:<br/>
        /// - `clip`: Generates one embedding for each segment<br/>
        /// - `asset`: Generates one embedding for the entire video file. Use this scope for videos up to 10-30 seconds to maintain optimal performance.<br/>
        /// You can specify multiple scopes to generate embeddings at different levels.<br/>
        /// **Default**: `["clip", "asset"]`
        /// </param>
        /// <param name="embeddingType">
        /// Specifies how to structure the embedding. Include this parameter only when `embedding_option` contains at least two values.<br/>
        /// **Values**:<br/>
        /// - `separate_embedding`: Returns separate embeddings per modality specified in `embedding_option`<br/>
        /// - `fused_embedding`: Returns a single embedding that combines all modalities into one vector<br/>
        /// Specify both values to receive separate and fused embeddings in the same response.<br/>
        /// **Default**: `separate_embedding`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoInputRequest(
            global::G.MediaSource mediaSource,
            double? startSec,
            double? endSec,
            global::G.VideoSegmentation? segmentation,
            global::System.Collections.Generic.IList<global::G.VideoInputRequestEmbeddingOptionItems>? embeddingOption,
            global::System.Collections.Generic.IList<global::G.VideoInputRequestEmbeddingScopeItems>? embeddingScope,
            global::System.Collections.Generic.IList<global::G.VideoInputRequestEmbeddingTypeItems>? embeddingType)
        {
            this.MediaSource = mediaSource ?? throw new global::System.ArgumentNullException(nameof(mediaSource));
            this.StartSec = startSec;
            this.EndSec = endSec;
            this.Segmentation = segmentation;
            this.EmbeddingOption = embeddingOption;
            this.EmbeddingScope = embeddingScope;
            this.EmbeddingType = embeddingType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoInputRequest" /> class.
        /// </summary>
        public VideoInputRequest()
        {
        }
    }
}