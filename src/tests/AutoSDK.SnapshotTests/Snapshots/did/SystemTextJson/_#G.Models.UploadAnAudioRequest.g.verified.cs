//HintName: G.Models.UploadAnAudioRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadAnAudioRequest
    {
        /// <summary>
        /// The uploaded audio file, the file must not exceed 6MB in size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public byte[]? Audio { get; set; }

        /// <summary>
        /// The uploaded audio file, the file must not exceed 6MB in size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        public string? Audioname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// A URL to upload the audio to. If provided, the audio will be uploaded to this URL instead of the default bucket. https presigned URL supported. S3 presigned urls should have the putObject permission with content type audio/wav.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persist")]
        public string? Persist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAnAudioRequest" /> class.
        /// </summary>
        /// <param name="audio">
        /// The uploaded audio file, the file must not exceed 6MB in size.
        /// </param>
        /// <param name="audioname">
        /// The uploaded audio file, the file must not exceed 6MB in size.
        /// </param>
        /// <param name="sourceUrl"></param>
        /// <param name="resultUrl">
        /// A URL to upload the audio to. If provided, the audio will be uploaded to this URL instead of the default bucket. https presigned URL supported. S3 presigned urls should have the putObject permission with content type audio/wav.
        /// </param>
        /// <param name="persist"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadAnAudioRequest(
            byte[]? audio,
            string? audioname,
            string? sourceUrl,
            string? resultUrl,
            string? persist)
        {
            this.Audio = audio;
            this.Audioname = audioname;
            this.SourceUrl = sourceUrl;
            this.ResultUrl = resultUrl;
            this.Persist = persist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAnAudioRequest" /> class.
        /// </summary>
        public UploadAnAudioRequest()
        {
        }
    }
}