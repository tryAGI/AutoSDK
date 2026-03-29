//HintName: G.Models.FileControllerUploadV2Request2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileControllerUploadV2Request2
    {
        /// <summary>
        /// The URL of the audio or video file to be uploaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileControllerUploadV2Request2" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// The URL of the audio or video file to be uploaded.
        /// </param>
        public FileControllerUploadV2Request2(
            string? audioUrl)
        {
            this.AudioUrl = audioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileControllerUploadV2Request2" /> class.
        /// </summary>
        public FileControllerUploadV2Request2()
        {
        }
    }
}