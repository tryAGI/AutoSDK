//HintName: G.Models.VoiceVerificationResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceVerificationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requires_verification", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequiresVerification { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_verified", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsVerified { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verification_attempts")]
        public global::System.Collections.Generic.IList<global::G.VerificationAttemptResponseModel>? VerificationAttempts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceVerificationResponseModel" /> class.
        /// </summary>
        /// <param name="requiresVerification"></param>
        /// <param name="isVerified"></param>
        /// <param name="verificationFailures"></param>
        /// <param name="verificationAttemptsCount"></param>
        /// <param name="language"></param>
        /// <param name="verificationAttempts"></param>
        public VoiceVerificationResponseModel(
            bool requiresVerification,
            bool isVerified,
            global::System.Collections.Generic.IList<string> verificationFailures,
            int verificationAttemptsCount,
            string? language,
            global::System.Collections.Generic.IList<global::G.VerificationAttemptResponseModel>? verificationAttempts)
        {
            this.RequiresVerification = requiresVerification;
            this.IsVerified = isVerified;
            this.VerificationFailures = verificationFailures ?? throw new global::System.ArgumentNullException(nameof(verificationFailures));
            this.VerificationAttemptsCount = verificationAttemptsCount;
            this.Language = language;
            this.VerificationAttempts = verificationAttempts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceVerificationResponseModel" /> class.
        /// </summary>
        public VoiceVerificationResponseModel()
        {
        }
    }
}