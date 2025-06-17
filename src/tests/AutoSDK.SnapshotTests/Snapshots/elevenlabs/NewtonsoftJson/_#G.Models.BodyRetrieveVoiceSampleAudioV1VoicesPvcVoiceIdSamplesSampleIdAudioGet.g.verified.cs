//HintName: G.Models.BodyRetrieveVoiceSampleAudioV1VoicesPvcVoiceIdSamplesSampleIdAudioGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyRetrieveVoiceSampleAudioV1VoicesPvcVoiceIdSamplesSampleIdAudioGet
    {
        /// <summary>
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("remove_background_noise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRetrieveVoiceSampleAudioV1VoicesPvcVoiceIdSamplesSampleIdAudioGet" /> class.
        /// </summary>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        public BodyRetrieveVoiceSampleAudioV1VoicesPvcVoiceIdSamplesSampleIdAudioGet(
            bool? removeBackgroundNoise)
        {
            this.RemoveBackgroundNoise = removeBackgroundNoise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRetrieveVoiceSampleAudioV1VoicesPvcVoiceIdSamplesSampleIdAudioGet" /> class.
        /// </summary>
        public BodyRetrieveVoiceSampleAudioV1VoicesPvcVoiceIdSamplesSampleIdAudioGet()
        {
        }
    }
}