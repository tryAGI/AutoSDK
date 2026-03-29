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
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.FallbackAssemblyAITranscriber, global::G.FallbackAzureSpeechTranscriber, global::G.FallbackCustomTranscriber, global::G.FallbackDeepgramTranscriber, global::G.FallbackElevenLabsTranscriber, global::G.FallbackGladiaTranscriber, global::G.FallbackGoogleTranscriber, global::G.FallbackTalkscriberTranscriber, global::G.FallbackSpeechmaticsTranscriber, global::G.FallbackOpenAITranscriber, global::G.FallbackCartesiaTranscriber, global::G.FallbackSonioxTranscriber>> Transcribers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackTranscriberPlan" /> class.
        /// </summary>
        /// <param name="transcribers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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