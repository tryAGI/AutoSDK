//HintName: G.Models.RecordingResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"mime_type":"audio/mpeg","recording_id":"CwhRBWXzGAHq8TQ4Fs17","size_bytes":1000000,"transcription":"Hello, how are you?","upload_date_unix":1714204800}
    /// </summary>
    public sealed partial class RecordingResponseModel
    {
        /// <summary>
        /// The ID of the recording.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecordingId { get; set; }

        /// <summary>
        /// The MIME type of the recording.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// The size of the recording in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeBytes { get; set; }

        /// <summary>
        /// The date of the recording in Unix time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UploadDateUnix { get; set; }

        /// <summary>
        /// The transcription of the recording.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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