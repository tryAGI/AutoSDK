//HintName: G.Models.RecordingResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecordingResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recording_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RecordingId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int SizeBytes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int UploadDateUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription", Required = global::Newtonsoft.Json.Required.Always)]
        public string Transcription { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingResponseModel" /> class.
        /// </summary>
        /// <param name="recordingId"></param>
        /// <param name="mimeType"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="uploadDateUnix"></param>
        /// <param name="transcription"></param>
        public RecordingResponseModel(
            string recordingId,
            string mimeType,
            int sizeBytes,
            int uploadDateUnix,
            string transcription)
        {
            this.RecordingId = recordingId ?? throw new global::System.ArgumentNullException(nameof(recordingId));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.SizeBytes = sizeBytes;
            this.UploadDateUnix = uploadDateUnix;
            this.Transcription = transcription ?? throw new global::System.ArgumentNullException(nameof(transcription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingResponseModel" /> class.
        /// </summary>
        public RecordingResponseModel()
        {
        }
    }
}