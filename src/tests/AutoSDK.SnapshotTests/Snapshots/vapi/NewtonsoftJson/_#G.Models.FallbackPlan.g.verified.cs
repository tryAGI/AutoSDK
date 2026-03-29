//HintName: G.Models.FallbackPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackPlan
    {
        /// <summary>
        /// This is the list of voices to fallback to in the event that the primary voice provider fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.FallbackAzureVoice, global::G.FallbackCartesiaVoice, global::G.FallbackHumeVoice, global::G.FallbackCustomVoice, global::G.FallbackDeepgramVoice, global::G.FallbackElevenLabsVoice, global::G.FallbackVapiVoice, global::G.FallbackLMNTVoice, global::G.FallbackOpenAIVoice, global::G.FallbackPlayHTVoice, global::G.FallbackWellSaidVoice, global::G.FallbackRimeAIVoice, global::G.FallbackSmallestAIVoice, global::G.FallbackTavusVoice, global::G.FallbackNeuphonicVoice, global::G.FallbackSesameVoice, global::G.FallbackInworldVoice>> Voices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackPlan" /> class.
        /// </summary>
        /// <param name="voices">
        /// This is the list of voices to fallback to in the event that the primary voice provider fails.
        /// </param>
        public FallbackPlan(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.FallbackAzureVoice, global::G.FallbackCartesiaVoice, global::G.FallbackHumeVoice, global::G.FallbackCustomVoice, global::G.FallbackDeepgramVoice, global::G.FallbackElevenLabsVoice, global::G.FallbackVapiVoice, global::G.FallbackLMNTVoice, global::G.FallbackOpenAIVoice, global::G.FallbackPlayHTVoice, global::G.FallbackWellSaidVoice, global::G.FallbackRimeAIVoice, global::G.FallbackSmallestAIVoice, global::G.FallbackTavusVoice, global::G.FallbackNeuphonicVoice, global::G.FallbackSesameVoice, global::G.FallbackInworldVoice>> voices)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackPlan" /> class.
        /// </summary>
        public FallbackPlan()
        {
        }
    }
}