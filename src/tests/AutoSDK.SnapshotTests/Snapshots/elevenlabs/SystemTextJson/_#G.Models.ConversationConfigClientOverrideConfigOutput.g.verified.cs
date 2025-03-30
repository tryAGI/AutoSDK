//HintName: G.Models.ConversationConfigClientOverrideConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConfigClientOverrideConfigOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::G.AgentConfigOverrideConfig? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::G.TTSConversationalConfigOverrideConfig? Tts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideConfigOutput" /> class.
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="tts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConfigClientOverrideConfigOutput(
            global::G.AgentConfigOverrideConfig? agent,
            global::G.TTSConversationalConfigOverrideConfig? tts)
        {
            this.Agent = agent;
            this.Tts = tts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigClientOverrideConfigOutput" /> class.
        /// </summary>
        public ConversationConfigClientOverrideConfigOutput()
        {
        }
    }
}