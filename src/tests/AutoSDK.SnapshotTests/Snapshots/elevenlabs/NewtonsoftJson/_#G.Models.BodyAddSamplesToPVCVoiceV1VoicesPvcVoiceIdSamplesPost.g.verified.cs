//HintName: G.Models.BodyAddSamplesToPVCVoiceV1VoicesPvcVoiceIdSamplesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddSamplesToPVCVoiceV1VoicesPvcVoiceIdSamplesPost
    {
        /// <summary>
        /// Audio files used to create the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> Files { get; set; } = default!;

        /// <summary>
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_background_noise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSamplesToPVCVoiceV1VoicesPvcVoiceIdSamplesPost" /> class.
        /// </summary>
        /// <param name="files">
        /// Audio files used to create the voice.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </param>
        public BodyAddSamplesToPVCVoiceV1VoicesPvcVoiceIdSamplesPost(
            global::System.Collections.Generic.IList<byte[]> files,
            bool? removeBackgroundNoise)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.RemoveBackgroundNoise = removeBackgroundNoise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSamplesToPVCVoiceV1VoicesPvcVoiceIdSamplesPost" /> class.
        /// </summary>
        public BodyAddSamplesToPVCVoiceV1VoicesPvcVoiceIdSamplesPost()
        {
        }
    }
}