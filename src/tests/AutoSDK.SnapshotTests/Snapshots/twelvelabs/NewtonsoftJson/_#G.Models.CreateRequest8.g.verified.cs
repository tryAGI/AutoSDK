//HintName: G.Models.CreateRequest8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest8
    {
        /// <summary>
        /// The name of the model you want to use. The following models are available:<br/>
        ///   - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        ///   - `Marengo-retrieval-2.7`: **Deprecation notice**: Starting mid-March 2026, your videos will be automatically reindexed to Marengo 3.0. Marengo 2.7 will be deprecated once reindexing completes. See the [Migration guide](/v1.3/docs/get-started/migration-guide) for details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// Specify this parameter to upload a video from your local file system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_file")]
        public byte[]? VideoFile { get; set; }

        /// <summary>
        /// Specify this parameter to upload a video from your local file system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_filename")]
        public string? VideoFilename { get; set; }

        /// <summary>
        /// Specify this parameter to upload a video from a publicly accessible URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// The start offset in seconds from the beginning of the video where processing should begin. Specifying 0 means starting from the beginning of the video.<br/>
        /// **Default**: 0<br/>
        /// **Min**: 0<br/>
        /// **Max**: Duration of the video minus video_clip_length
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_start_offset_sec")]
        public double? VideoStartOffsetSec { get; set; }

        /// <summary>
        /// The end offset in seconds from the beginning of the video where processing should stop.<br/>
        /// Ensure the following when you specify this parameter:<br/>
        /// - The end offset does not exceed the total duration of the video file.<br/>
        /// - The end offset is greater than the start offset.<br/>
        /// - You must set both the start and end offsets. Setting only one of these offsets is not permitted, resulting in an error.<br/>
        /// **Min**: video_start_offset + video_clip_length<br/>
        /// **Max**: Duration of the video file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_end_offset_sec")]
        public double? VideoEndOffsetSec { get; set; }

        /// <summary>
        /// The desired duration in seconds for each clip for which the platform generates an embedding. Ensure that the clip length does not exceed the interval between the start and end offsets.<br/>
        /// **Default**: 6<br/>
        /// **Min**: 2<br/>
        /// **Max**: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_clip_length")]
        public double? VideoClipLength { get; set; }

        /// <summary>
        /// Defines the scope of video embedding generation. Valid values are the following:<br/>
        /// - `clip`: Creates embeddings for each video segment of `video_clip_length` seconds, from `video_start_offset_sec` to `video_end_offset_sec`.<br/>
        /// - `clip` and `video`: Creates embeddings for video segments and the entire video. Use the `video` scope for videos up to 10-30 seconds to maintain optimal performance.<br/>
        /// To create embeddings for segments and the entire video in the same request, include this parameter twice as shown below:<br/>
        /// ```json<br/>
        /// --form video_embedding_scope=clip \<br/>
        /// --form video_embedding_scope=video<br/>
        /// ```<br/>
        /// **Default**: `clip`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_embedding_scope")]
        public global::System.Collections.Generic.IList<global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? VideoEmbeddingScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest8" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the model you want to use. The following models are available:<br/>
        ///   - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        ///   - `Marengo-retrieval-2.7`: **Deprecation notice**: Starting mid-March 2026, your videos will be automatically reindexed to Marengo 3.0. Marengo 2.7 will be deprecated once reindexing completes. See the [Migration guide](/v1.3/docs/get-started/migration-guide) for details.
        /// </param>
        /// <param name="videoFile">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoFilename">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoUrl">
        /// Specify this parameter to upload a video from a publicly accessible URL.
        /// </param>
        /// <param name="videoStartOffsetSec">
        /// The start offset in seconds from the beginning of the video where processing should begin. Specifying 0 means starting from the beginning of the video.<br/>
        /// **Default**: 0<br/>
        /// **Min**: 0<br/>
        /// **Max**: Duration of the video minus video_clip_length
        /// </param>
        /// <param name="videoEndOffsetSec">
        /// The end offset in seconds from the beginning of the video where processing should stop.<br/>
        /// Ensure the following when you specify this parameter:<br/>
        /// - The end offset does not exceed the total duration of the video file.<br/>
        /// - The end offset is greater than the start offset.<br/>
        /// - You must set both the start and end offsets. Setting only one of these offsets is not permitted, resulting in an error.<br/>
        /// **Min**: video_start_offset + video_clip_length<br/>
        /// **Max**: Duration of the video file
        /// </param>
        /// <param name="videoClipLength">
        /// The desired duration in seconds for each clip for which the platform generates an embedding. Ensure that the clip length does not exceed the interval between the start and end offsets.<br/>
        /// **Default**: 6<br/>
        /// **Min**: 2<br/>
        /// **Max**: 10
        /// </param>
        /// <param name="videoEmbeddingScope">
        /// Defines the scope of video embedding generation. Valid values are the following:<br/>
        /// - `clip`: Creates embeddings for each video segment of `video_clip_length` seconds, from `video_start_offset_sec` to `video_end_offset_sec`.<br/>
        /// - `clip` and `video`: Creates embeddings for video segments and the entire video. Use the `video` scope for videos up to 10-30 seconds to maintain optimal performance.<br/>
        /// To create embeddings for segments and the entire video in the same request, include this parameter twice as shown below:<br/>
        /// ```json<br/>
        /// --form video_embedding_scope=clip \<br/>
        /// --form video_embedding_scope=video<br/>
        /// ```<br/>
        /// **Default**: `clip`
        /// </param>
        public CreateRequest8(
            string modelName,
            byte[]? videoFile,
            string? videoFilename,
            string? videoUrl,
            double? videoStartOffsetSec,
            double? videoEndOffsetSec,
            double? videoClipLength,
            global::System.Collections.Generic.IList<global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? videoEmbeddingScope)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.VideoFile = videoFile;
            this.VideoFilename = videoFilename;
            this.VideoUrl = videoUrl;
            this.VideoStartOffsetSec = videoStartOffsetSec;
            this.VideoEndOffsetSec = videoEndOffsetSec;
            this.VideoClipLength = videoClipLength;
            this.VideoEmbeddingScope = videoEmbeddingScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest8" /> class.
        /// </summary>
        public CreateRequest8()
        {
        }
    }
}