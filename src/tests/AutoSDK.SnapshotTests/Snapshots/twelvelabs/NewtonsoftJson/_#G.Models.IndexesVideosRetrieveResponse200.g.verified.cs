//HintName: G.Models.IndexesVideosRetrieveResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexesVideosRetrieveResponse200
    {
        /// <summary>
        /// The unique identifier of the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the video indexing task was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the corresponding video indexing task was last updated. The platform updates this field every time the corresponding video indexing task transitions to a different state.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the video indexing task has been completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexed_at")]
        public string? IndexedAt { get; set; }

        /// <summary>
        /// System-generated metadata about the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_metadata")]
        public global::G.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata? SystemMetadata { get; set; }

        /// <summary>
        /// User-generated metadata about the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_metadata")]
        public object? UserMetadata { get; set; }

        /// <summary>
        /// The platform returns this object only for the videos that you uploaded with the `enable_video_stream` parameter set to `true`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hls")]
        public global::G.HLSObject? Hls { get; set; }

        /// <summary>
        /// Contains the embedding and the associated information. The platform returns this field when the `embedding_option` parameter is specified in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public global::G.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding? Embedding { get; set; }

        /// <summary>
        /// An array of objects that contains the transcription. For each time range for which the platform finds spoken words, it returns an object that contains the fields below. If the platform doesn't find any spoken words, the `data` field is set to `null`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionDataItems>? Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesVideosRetrieveResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the video.
        /// </param>
        /// <param name="createdAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the video indexing task was created.
        /// </param>
        /// <param name="updatedAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the corresponding video indexing task was last updated. The platform updates this field every time the corresponding video indexing task transitions to a different state.
        /// </param>
        /// <param name="indexedAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the video indexing task has been completed.
        /// </param>
        /// <param name="systemMetadata">
        /// System-generated metadata about the video.
        /// </param>
        /// <param name="userMetadata">
        /// User-generated metadata about the video.
        /// </param>
        /// <param name="hls">
        /// The platform returns this object only for the videos that you uploaded with the `enable_video_stream` parameter set to `true`.
        /// </param>
        /// <param name="embedding">
        /// Contains the embedding and the associated information. The platform returns this field when the `embedding_option` parameter is specified in the request.
        /// </param>
        /// <param name="transcription">
        /// An array of objects that contains the transcription. For each time range for which the platform finds spoken words, it returns an object that contains the fields below. If the platform doesn't find any spoken words, the `data` field is set to `null`.
        /// </param>
        public IndexesVideosRetrieveResponse200(
            string? id,
            string? createdAt,
            string? updatedAt,
            string? indexedAt,
            global::G.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaSystemMetadata? systemMetadata,
            object? userMetadata,
            global::G.HLSObject? hls,
            global::G.IndexesIndexIdVideosVideoIdGetResponsesContentApplicationJsonSchemaEmbedding? embedding,
            global::System.Collections.Generic.IList<global::G.TranscriptionDataItems>? transcription)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IndexedAt = indexedAt;
            this.SystemMetadata = systemMetadata;
            this.UserMetadata = userMetadata;
            this.Hls = hls;
            this.Embedding = embedding;
            this.Transcription = transcription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesVideosRetrieveResponse200" /> class.
        /// </summary>
        public IndexesVideosRetrieveResponse200()
        {
        }
    }
}