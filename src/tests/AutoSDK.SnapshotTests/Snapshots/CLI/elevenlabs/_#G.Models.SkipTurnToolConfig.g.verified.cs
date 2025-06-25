//HintName: G.Models.SkipTurnToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allows the agent to explicitly skip its turn.<br/>
    /// This tool should be invoked by the LLM when the user indicates they would like<br/>
    /// to think or take a short pause before continuing the conversation—e.g. when<br/>
    /// they say: "Give me a second", "Let me think", or "One moment please".  After<br/>
    /// calling this tool, the assistant should not speak until the user speaks<br/>
    /// again, or another normal turn-taking condition is met.  The tool itself has<br/>
    /// no parameters and performs no side-effects other than informing the backend<br/>
    /// that the current turn generation is complete.
    /// </summary>
    public sealed partial class SkipTurnToolConfig
    {
        /// <summary>
        /// Default Value: skip_turn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SkipTurnToolConfigSystemToolTypeJsonConverter))]
        public global::G.SkipTurnToolConfigSystemToolType? SystemToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipTurnToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: skip_turn
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkipTurnToolConfig(
            global::G.SkipTurnToolConfigSystemToolType? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipTurnToolConfig" /> class.
        /// </summary>
        public SkipTurnToolConfig()
        {
        }
    }
}