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
        /// The ID of the recording.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recording_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RecordingId { get; set; } = default!;

        /// <summary>
        /// The MIME type of the recording.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// The size of the recording in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int SizeBytes { get; set; } = default!;

        /// <summary>
        /// The date of the recording in Unix time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_date_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int UploadDateUnix { get; set; } = default!;

        /// <summary>
        /// The transcription of the recording.
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
        /// <param name="recordingId">
        /// The ID of the recording.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the recording.
        /// </param>
        /// <param name="sizeBytes">
        /// The size of the recording in bytes.
        /// </param>
        /// <param name="uploadDateUnix">
        /// The date of the recording in Unix time.
        /// </param>
        /// <param name="transcription">
        /// The transcription of the recording.
        /// </param>
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