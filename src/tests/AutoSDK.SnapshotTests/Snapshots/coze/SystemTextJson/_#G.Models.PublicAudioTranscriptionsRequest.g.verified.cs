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
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// 音频文件，应使用 multipart/form-data 方式上传文件。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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