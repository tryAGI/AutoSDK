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
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_background_noise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSamplesToPVCVoiceV1VoicesPvcVoiceIdSamplesPost" /> class.
        /// </summary>
        /// <param name="files">
        /// Audio files used to create the voice.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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