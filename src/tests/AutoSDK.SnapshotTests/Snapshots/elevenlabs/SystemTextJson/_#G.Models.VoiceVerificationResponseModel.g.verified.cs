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
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiresVerification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsVerified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_failures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VerificationFailures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_attempts_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VerificationAttemptsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
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
        /// <param name="requiresVerification"></param>
        /// <param name="isVerified"></param>
        /// <param name="verificationFailures"></param>
        /// <param name="verificationAttemptsCount"></param>
        /// <param name="language"></param>
        /// <param name="verificationAttempts"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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