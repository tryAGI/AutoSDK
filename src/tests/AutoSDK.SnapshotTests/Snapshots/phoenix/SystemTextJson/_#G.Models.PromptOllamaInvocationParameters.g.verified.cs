//HintName: G.Models.PromptOllamaInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOllamaInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"ollama"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "ollama";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ollama")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptOllamaInvocationParametersContent Ollama { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOllamaInvocationParameters" /> class.
        /// </summary>
        /// <param name="ollama"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptOllamaInvocationParameters(
            global::G.PromptOllamaInvocationParametersContent ollama,
            string type = "ollama")
        {
            this.Type = type;
            this.Ollama = ollama ?? throw new global::System.ArgumentNullException(nameof(ollama));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOllamaInvocationParameters" /> class.
        /// </summary>
        public PromptOllamaInvocationParameters()
        {
        }
    }
}