//HintName: G.Models.FallbackTranscriberPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackTranscriberPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcribers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.FallbackAssemblyAITranscriber, global::G.FallbackAzureSpeechTranscriber, global::G.FallbackCustomTranscriber, global::G.FallbackDeepgramTranscriber, global::G.FallbackElevenLabsTranscriber, global::G.FallbackGladiaTranscriber, global::G.FallbackGoogleTranscriber, global::G.FallbackTalkscriberTranscriber, global::G.FallbackSpeechmaticsTranscriber, global::G.FallbackOpenAITranscriber, global::G.FallbackCartesiaTranscriber, global::G.FallbackSonioxTranscriber>> Transcribers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackTranscriberPlan" /> class.
        /// </summary>
        /// <param name="transcribers"></param>
        public FallbackTranscriberPlan(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.FallbackAssemblyAITranscriber, global::G.FallbackAzureSpeechTranscriber, global::G.FallbackCustomTranscriber, global::G.FallbackDeepgramTranscriber, global::G.FallbackElevenLabsTranscriber, global::G.FallbackGladiaTranscriber, global::G.FallbackGoogleTranscriber, global::G.FallbackTalkscriberTranscriber, global::G.FallbackSpeechmaticsTranscriber, global::G.FallbackOpenAITranscriber, global::G.FallbackCartesiaTranscriber, global::G.FallbackSonioxTranscriber>> transcribers)
        {
            this.Transcribers = transcribers ?? throw new global::System.ArgumentNullException(nameof(transcribers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackTranscriberPlan" /> class.
        /// </summary>
        public FallbackTranscriberPlan()
        {
        }
    }
}