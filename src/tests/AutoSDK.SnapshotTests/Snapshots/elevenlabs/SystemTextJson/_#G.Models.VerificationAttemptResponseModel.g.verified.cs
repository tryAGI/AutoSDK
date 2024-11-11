//HintName: G.Models.VerificationAttemptResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VerificationAttemptResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DateUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Accepted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Similarity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("levenshtein_distance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LevenshteinDistance { get; set; }

        /// <summary>
        /// 
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
        /// <param name="text"></param>
        /// <param name="dateUnix"></param>
        /// <param name="accepted"></param>
        /// <param name="similarity"></param>
        /// <param name="levenshteinDistance"></param>
        /// <param name="recording"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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