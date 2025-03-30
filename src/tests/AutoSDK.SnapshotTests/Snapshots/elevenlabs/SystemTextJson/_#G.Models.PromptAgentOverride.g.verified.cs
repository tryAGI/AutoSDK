//HintName: G.Models.PromptAgentOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentOverride
    {
        /// <summary>
        /// The initial system message that defines the agent, e.g. “You are a German language teacher named Laura.”
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentOverride" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The initial system message that defines the agent, e.g. “You are a German language teacher named Laura.”
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAgentOverride(
            string? prompt)
        {
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentOverride" /> class.
        /// </summary>
        public PromptAgentOverride()
        {
        }
    }
}