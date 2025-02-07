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
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecordingId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UploadDateUnix { get; set; }

        /// <summary>
        /// 
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
        /// <param name="recordingId"></param>
        /// <param name="mimeType"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="uploadDateUnix"></param>
        /// <param name="transcription"></param>
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