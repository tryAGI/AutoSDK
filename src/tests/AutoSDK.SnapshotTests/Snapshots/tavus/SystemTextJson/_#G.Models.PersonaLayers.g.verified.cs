//HintName: G.Models.PersonaLayers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PersonaLayers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perception")]
        public global::G.PerceptionLayer? Perception { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt")]
        public global::G.SttLayer? Stt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversational_flow")]
        public global::G.ConversationalFlowLayer? ConversationalFlow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::G.LlmLayer? Llm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::G.TtsLayer? Tts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaLayers" /> class.
        /// </summary>
        /// <param name="perception"></param>
        /// <param name="stt"></param>
        /// <param name="conversationalFlow"></param>
        /// <param name="llm"></param>
        /// <param name="tts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersonaLayers(
            global::G.PerceptionLayer? perception,
            global::G.SttLayer? stt,
            global::G.ConversationalFlowLayer? conversationalFlow,
            global::G.LlmLayer? llm,
            global::G.TtsLayer? tts)
        {
            this.Perception = perception;
            this.Stt = stt;
            this.ConversationalFlow = conversationalFlow;
            this.Llm = llm;
            this.Tts = tts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaLayers" /> class.
        /// </summary>
        public PersonaLayers()
        {
        }
    }
}