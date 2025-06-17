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
        [global::Newtonsoft.Json.JsonProperty("recording", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Recording { get; set; } = default!;

        /// <summary>
        /// Audio recording of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordingname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Recordingname { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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