//HintName: G.Models.PublicAudioTranscriptionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAudioTranscriptionsRequest
    {
        /// <summary>
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAudioTranscriptionsRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </param>
        /// <param name="filename">
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </param>
        public PublicAudioTranscriptionsRequest(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAudioTranscriptionsRequest" /> class.
        /// </summary>
        public PublicAudioTranscriptionsRequest()
        {
        }
    }
}