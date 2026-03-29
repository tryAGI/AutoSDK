//HintName: G.Models.PromptAnthropicInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAnthropicInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"anthropic"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "anthropic";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anthropic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptAnthropicInvocationParametersContent Anthropic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParameters" /> class.
        /// </summary>
        /// <param name="anthropic"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAnthropicInvocationParameters(
            global::G.PromptAnthropicInvocationParametersContent anthropic,
            string type = "anthropic")
        {
            this.Type = type;
            this.Anthropic = anthropic ?? throw new global::System.ArgumentNullException(nameof(anthropic));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParameters" /> class.
        /// </summary>
        public PromptAnthropicInvocationParameters()
        {
        }
    }
}