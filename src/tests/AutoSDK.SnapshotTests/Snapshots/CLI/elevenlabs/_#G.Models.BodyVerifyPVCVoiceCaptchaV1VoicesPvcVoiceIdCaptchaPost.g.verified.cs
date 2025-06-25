//HintName: G.Models.BodyVerifyPVCVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyVerifyPVCVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost
    {
        /// <summary>
        /// Audio recording of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Recording { get; set; }

        /// <summary>
        /// Audio recording of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Recordingname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyVerifyPVCVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost" /> class.
        /// </summary>
        /// <param name="recording">
        /// Audio recording of the user
        /// </param>
        /// <param name="recordingname">
        /// Audio recording of the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyVerifyPVCVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost(
            byte[] recording,
            string recordingname)
        {
            this.Recording = recording ?? throw new global::System.ArgumentNullException(nameof(recording));
            this.Recordingname = recordingname ?? throw new global::System.ArgumentNullException(nameof(recordingname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyVerifyPVCVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost" /> class.
        /// </summary>
        public BodyVerifyPVCVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost()
        {
        }
    }
}