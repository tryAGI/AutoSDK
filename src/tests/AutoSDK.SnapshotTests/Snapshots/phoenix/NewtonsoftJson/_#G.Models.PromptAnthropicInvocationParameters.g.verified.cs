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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "anthropic";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anthropic", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptAnthropicInvocationParametersContent Anthropic { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParameters" /> class.
        /// </summary>
        /// <param name="anthropic"></param>
        /// <param name="type"></param>
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