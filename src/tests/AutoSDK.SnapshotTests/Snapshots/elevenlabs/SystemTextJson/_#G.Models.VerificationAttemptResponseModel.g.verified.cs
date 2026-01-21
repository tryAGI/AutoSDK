//HintName: G.Models.VerificationAttemptResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"accepted":true,"date_unix":1714204800,"levenshtein_distance":2,"recording":{"mime_type":"audio/mpeg","recording_id":"CwhRBWXzGAHq8TQ4Fs17","size_bytes":1000000,"transcription":"Hello, how are you?","upload_date_unix":1714204800},"similarity":0.95,"text":"Hello, how are you?"}
    /// </summary>
    public sealed partial class VerificationAttemptResponseModel
    {
        /// <summary>
        /// The text of the verification attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The date of the verification attempt in Unix time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DateUnix { get; set; }

        /// <summary>
        /// Whether the verification attempt was accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Accepted { get; set; }

        /// <summary>
        /// The similarity of the verification attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Similarity { get; set; }

        /// <summary>
        /// The Levenshtein distance of the verification attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("levenshtein_distance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LevenshteinDistance { get; set; }

        /// <summary>
        /// The recording of the verification attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording")]
        public global::G.RecordingResponseModel? Recording { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationAttemptResponseModel" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the verification attempt.
        /// </param>
        /// <param name="dateUnix">
        /// The date of the verification attempt in Unix time.
        /// </param>
        /// <param name="accepted">
        /// Whether the verification attempt was accepted.
        /// </param>
        /// <param name="similarity">
        /// The similarity of the verification attempt.
        /// </param>
        /// <param name="levenshteinDistance">
        /// The Levenshtein distance of the verification attempt.
        /// </param>
        /// <param name="recording">
        /// The recording of the verification attempt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerificationAttemptResponseModel(
            string text,
            int dateUnix,
            bool accepted,
            double similarity,
            double levenshteinDistance,
            global::G.RecordingResponseModel? recording)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.DateUnix = dateUnix;
            this.Accepted = accepted;
            this.Similarity = similarity;
            this.LevenshteinDistance = levenshteinDistance;
            this.Recording = recording;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationAttemptResponseModel" /> class.
        /// </summary>
        public VerificationAttemptResponseModel()
        {
        }
    }
}