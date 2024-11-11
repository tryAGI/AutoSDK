//HintName: G.Models.TranscriptParamsVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptParamsVariant1
    {
        /// <summary>
        /// The URL of the audio or video file to transcribe.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptParamsVariant1" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// The URL of the audio or video file to transcribe.
        /// </param>
        public TranscriptParamsVariant1(
            string audioUrl)
        {
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptParamsVariant1" /> class.
        /// </summary>
        public TranscriptParamsVariant1()
        {
        }
    }
}