//HintName: G.Models.FineTuningResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuningResponseModel
    {
        /// <summary>
        /// Whether the user is allowed to fine-tune the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_allowed_to_fine_tune")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAllowedToFineTune { get; set; }

        /// <summary>
        /// The state of the fine-tuning process for each model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.FineTuningResponseModelState2> State { get; set; }

        /// <summary>
        /// List of verification failures in the fine-tuning process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_failures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VerificationFailures { get; set; }

        /// <summary>
        /// The number of verification attempts in the fine-tuning process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_attempts_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VerificationAttemptsCount { get; set; }

        /// <summary>
        /// Whether a manual verification was requested for the fine-tuning process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_verification_requested")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ManualVerificationRequested { get; set; }

        /// <summary>
        /// The language of the fine-tuning process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The progress of the fine-tuning process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::System.Collections.Generic.Dictionary<string, double>? Progress { get; set; }

        /// <summary>
        /// The message of the fine-tuning process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::System.Collections.Generic.Dictionary<string, string>? Message { get; set; }

        /// <summary>
        /// The duration of the dataset in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_duration_seconds")]
        public double? DatasetDurationSeconds { get; set; }

        /// <summary>
        /// The number of verification attempts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_attempts")]
        public global::System.Collections.Generic.IList<global::G.VerificationAttemptResponseModel>? VerificationAttempts { get; set; }

        /// <summary>
        /// List of slice IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slice_ids")]
        public global::System.Collections.Generic.IList<string>? SliceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_verification")]
        public global::G.ManualVerificationResponseModel? ManualVerification { get; set; }

        /// <summary>
        /// The maximum number of verification attempts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_verification_attempts")]
        public int? MaxVerificationAttempts { get; set; }

        /// <summary>
        /// The next maximum verification attempts reset time in Unix milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_max_verification_attempts_reset_unix_ms")]
        public int? NextMaxVerificationAttemptsResetUnixMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningResponseModel" /> class.
        /// </summary>
        /// <param name="isAllowedToFineTune">
        /// Whether the user is allowed to fine-tune the voice.
        /// </param>
        /// <param name="state">
        /// The state of the fine-tuning process for each model.
        /// </param>
        /// <param name="verificationFailures">
        /// List of verification failures in the fine-tuning process.
        /// </param>
        /// <param name="verificationAttemptsCount">
        /// The number of verification attempts in the fine-tuning process.
        /// </param>
        /// <param name="manualVerificationRequested">
        /// Whether a manual verification was requested for the fine-tuning process.
        /// </param>
        /// <param name="language">
        /// The language of the fine-tuning process.
        /// </param>
        /// <param name="progress">
        /// The progress of the fine-tuning process.
        /// </param>
        /// <param name="message">
        /// The message of the fine-tuning process.
        /// </param>
        /// <param name="datasetDurationSeconds">
        /// The duration of the dataset in seconds.
        /// </param>
        /// <param name="verificationAttempts">
        /// The number of verification attempts.
        /// </param>
        /// <param name="sliceIds">
        /// List of slice IDs.
        /// </param>
        /// <param name="manualVerification"></param>
        /// <param name="maxVerificationAttempts">
        /// The maximum number of verification attempts.
        /// </param>
        /// <param name="nextMaxVerificationAttemptsResetUnixMs">
        /// The next maximum verification attempts reset time in Unix milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuningResponseModel(
            bool isAllowedToFineTune,
            global::System.Collections.Generic.Dictionary<string, global::G.FineTuningResponseModelState2> state,
            global::System.Collections.Generic.IList<string> verificationFailures,
            int verificationAttemptsCount,
            bool manualVerificationRequested,
            string? language,
            global::System.Collections.Generic.Dictionary<string, double>? progress,
            global::System.Collections.Generic.Dictionary<string, string>? message,
            double? datasetDurationSeconds,
            global::System.Collections.Generic.IList<global::G.VerificationAttemptResponseModel>? verificationAttempts,
            global::System.Collections.Generic.IList<string>? sliceIds,
            global::G.ManualVerificationResponseModel? manualVerification,
            int? maxVerificationAttempts,
            int? nextMaxVerificationAttemptsResetUnixMs)
        {
            this.IsAllowedToFineTune = isAllowedToFineTune;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.VerificationFailures = verificationFailures ?? throw new global::System.ArgumentNullException(nameof(verificationFailures));
            this.VerificationAttemptsCount = verificationAttemptsCount;
            this.ManualVerificationRequested = manualVerificationRequested;
            this.Language = language;
            this.Progress = progress;
            this.Message = message;
            this.DatasetDurationSeconds = datasetDurationSeconds;
            this.VerificationAttempts = verificationAttempts;
            this.SliceIds = sliceIds;
            this.ManualVerification = manualVerification;
            this.MaxVerificationAttempts = maxVerificationAttempts;
            this.NextMaxVerificationAttemptsResetUnixMs = nextMaxVerificationAttemptsResetUnixMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningResponseModel" /> class.
        /// </summary>
        public FineTuningResponseModel()
        {
        }
    }
}