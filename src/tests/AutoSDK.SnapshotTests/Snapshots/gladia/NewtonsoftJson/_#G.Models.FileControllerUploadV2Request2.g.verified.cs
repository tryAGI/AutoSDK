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
        /// The file to be uploaded. This should be an audio or video file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public byte[]? Audio { get; set; }

        /// <summary>
        /// The file to be uploaded. This should be an audio or video file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audioname")]
        public string? Audioname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileControllerUploadV2Request2" /> class.
        /// </summary>
        /// <param name="audio">
        /// The file to be uploaded. This should be an audio or video file.
        /// </param>
        /// <param name="audioname">
        /// The file to be uploaded. This should be an audio or video file.
        /// </param>
        public FileControllerUploadV2Request2(
            byte[]? audio,
            string? audioname)
        {
            this.Audio = audio;
            this.Audioname = audioname;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileControllerUploadV2Request2" /> class.
        /// </summary>
        public FileControllerUploadV2Request2()
        {
        }

    }
}