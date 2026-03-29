//HintName: G.Models.AudioInputRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is required if the `input_type` parameter is `audio`.
    /// </summary>
    public sealed partial class AudioInputRequest
    {
        /// <summary>
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MediaSource MediaSource { get; set; } = default!;

        /// <summary>
        /// The start time in seconds for processing the audio file.<br/>
        /// Use this parameter to process a portion of the audio file starting from a specific time.<br/>
        /// **Default**: 0 (start from the beginning).<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_sec")]
        public double? StartSec { get; set; }

        /// <summary>
        /// The end time in seconds for processing the audio file.<br/>
        /// Use this parameter to process a portion of the audio file ending at a specific time. The end time must be greater than the start time.<br/>
        /// **Default**: End of the audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_sec")]
        public double? EndSec { get; set; }

        /// <summary>
        /// Specifies how the platform divides the audio into segments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segmentation")]
        public global::G.AudioSegmentation? Segmentation { get; set; }

        /// <summary>
        /// The types of embeddings you wish to generate.<br/>
        /// **Values**:<br/>
        /// - `audio`: Generates embeddings based on audio content (sounds, music, effects)<br/>
        /// - `transcription`: Generates embeddings based on transcribed speech<br/>
        /// You can specify multiple options to generate different types of embeddings for the same audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_option")]
        public global::System.Collections.Generic.IList<global::G.AudioInputRequestEmbeddingOptionItems>? EmbeddingOption { get; set; }

        /// <summary>
        /// The scope for which you wish to generate embeddings.<br/>
        /// **Values**:<br/>
        /// - `clip`: Generates one embedding for each segment<br/>
        /// - `asset`: Generates one embedding for the entire audio file<br/>
        /// You can specify multiple scopes to generate embeddings at different levels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_scope")]
        public global::System.Collections.Generic.IList<global::G.AudioInputRequestEmbeddingScopeItems>? EmbeddingScope { get; set; }

        /// <summary>
        /// Specifies how to structure the embedding. Include this parameter only when the `embedding_option` parameter contains at least two values.<br/>
        /// **Values**:<br/>
        /// - `separate_embedding`: Returns separate embeddings for each modality specified in the `embedding_option` parameter.<br/>
        /// - `fused_embedding`: Returns a single combined embedding that integrates all modalities into one vector.<br/>
        /// Specify both values to receive separate and fused embeddings in the same response.<br/>
        /// **Default**: `separate_embedding`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_type")]
        public global::System.Collections.Generic.IList<global::G.AudioInputRequestEmbeddingTypeItems>? EmbeddingType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioInputRequest" /> class.
        /// </summary>
        /// <param name="mediaSource">
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </param>
        /// <param name="startSec">
        /// The start time in seconds for processing the audio file.<br/>
        /// Use this parameter to process a portion of the audio file starting from a specific time.<br/>
        /// **Default**: 0 (start from the beginning).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="endSec">
        /// The end time in seconds for processing the audio file.<br/>
        /// Use this parameter to process a portion of the audio file ending at a specific time. The end time must be greater than the start time.<br/>
        /// **Default**: End of the audio file
        /// </param>
        /// <param name="segmentation">
        /// Specifies how the platform divides the audio into segments.
        /// </param>
        /// <param name="embeddingOption">
        /// The types of embeddings you wish to generate.<br/>
        /// **Values**:<br/>
        /// - `audio`: Generates embeddings based on audio content (sounds, music, effects)<br/>
        /// - `transcription`: Generates embeddings based on transcribed speech<br/>
        /// You can specify multiple options to generate different types of embeddings for the same audio.
        /// </param>
        /// <param name="embeddingScope">
        /// The scope for which you wish to generate embeddings.<br/>
        /// **Values**:<br/>
        /// - `clip`: Generates one embedding for each segment<br/>
        /// - `asset`: Generates one embedding for the entire audio file<br/>
        /// You can specify multiple scopes to generate embeddings at different levels.
        /// </param>
        /// <param name="embeddingType">
        /// Specifies how to structure the embedding. Include this parameter only when the `embedding_option` parameter contains at least two values.<br/>
        /// **Values**:<br/>
        /// - `separate_embedding`: Returns separate embeddings for each modality specified in the `embedding_option` parameter.<br/>
        /// - `fused_embedding`: Returns a single combined embedding that integrates all modalities into one vector.<br/>
        /// Specify both values to receive separate and fused embeddings in the same response.<br/>
        /// **Default**: `separate_embedding`.
        /// </param>
        public AudioInputRequest(
            global::G.MediaSource mediaSource,
            double? startSec,
            double? endSec,
            global::G.AudioSegmentation? segmentation,
            global::System.Collections.Generic.IList<global::G.AudioInputRequestEmbeddingOptionItems>? embeddingOption,
            global::System.Collections.Generic.IList<global::G.AudioInputRequestEmbeddingScopeItems>? embeddingScope,
            global::System.Collections.Generic.IList<global::G.AudioInputRequestEmbeddingTypeItems>? embeddingType)
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
        /// Initializes a new instance of the <see cref="AudioInputRequest" /> class.
        /// </summary>
        public AudioInputRequest()
        {
        }
    }
}