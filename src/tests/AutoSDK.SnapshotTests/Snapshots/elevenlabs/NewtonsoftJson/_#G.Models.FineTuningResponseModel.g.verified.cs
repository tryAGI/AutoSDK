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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_allowed_to_fine_tune", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAllowedToFineTune { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.FineTuningResponseModelState2> State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verification_failures", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> VerificationFailures { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verification_attempts_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int VerificationAttemptsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manual_verification_requested", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ManualVerificationRequested { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public global::System.Collections.Generic.Dictionary<string, double>? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::System.Collections.Generic.Dictionary<string, string>? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_duration_seconds")]
        public double? DatasetDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verification_attempts")]
        public global::System.Collections.Generic.IList<global::G.VerificationAttemptResponseModel>? VerificationAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slice_ids")]
        public global::System.Collections.Generic.IList<string>? SliceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manual_verification")]
        public global::G.ManualVerificationResponseModel? ManualVerification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningResponseModel" /> class.
        /// </summary>
        /// <param name="isAllowedToFineTune"></param>
        /// <param name="state"></param>
        /// <param name="verificationFailures"></param>
        /// <param name="verificationAttemptsCount"></param>
        /// <param name="manualVerificationRequested"></param>
        /// <param name="language"></param>
        /// <param name="progress"></param>
        /// <param name="message"></param>
        /// <param name="datasetDurationSeconds"></param>
        /// <param name="verificationAttempts"></param>
        /// <param name="sliceIds"></param>
        /// <param name="manualVerification"></param>
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
            global::G.ManualVerificationResponseModel? manualVerification)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningResponseModel" /> class.
        /// </summary>
        public FineTuningResponseModel()
        {
        }
    }
}