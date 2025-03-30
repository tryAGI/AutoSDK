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
        /// Whether the voice requires verification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresVerification { get; set; }

        /// <summary>
        /// Whether the voice has been verified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsVerified { get; set; }

        /// <summary>
        /// List of verification failures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_failures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VerificationFailures { get; set; }

        /// <summary>
        /// The number of verification attempts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_attempts_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VerificationAttemptsCount { get; set; }

        /// <summary>
        /// The language of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Number of times a verification was attempted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_attempts")]
        public global::System.Collections.Generic.IList<global::G.VerificationAttemptResponseModel>? VerificationAttempts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceVerificationResponseModel" /> class.
        /// </summary>
        /// <param name="requiresVerification">
        /// Whether the voice requires verification.
        /// </param>
        /// <param name="isVerified">
        /// Whether the voice has been verified.
        /// </param>
        /// <param name="verificationFailures">
        /// List of verification failures.
        /// </param>
        /// <param name="verificationAttemptsCount">
        /// The number of verification attempts.
        /// </param>
        /// <param name="language">
        /// The language of the voice.
        /// </param>
        /// <param name="verificationAttempts">
        /// Number of times a verification was attempted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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