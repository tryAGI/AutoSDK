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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "ollama";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ollama", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptOllamaInvocationParametersContent Ollama { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOllamaInvocationParameters" /> class.
        /// </summary>
        /// <param name="ollama"></param>
        /// <param name="type"></param>
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