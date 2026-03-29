//HintName: G.Models.PromptOpenAIInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOpenAIInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"openai"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "openai";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openai", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptOpenAIInvocationParametersContent Openai { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOpenAIInvocationParameters" /> class.
        /// </summary>
        /// <param name="openai"></param>
        /// <param name="type"></param>
        public PromptOpenAIInvocationParameters(
            global::G.PromptOpenAIInvocationParametersContent openai,
            string type = "openai")
        {
            this.Type = type;
            this.Openai = openai ?? throw new global::System.ArgumentNullException(nameof(openai));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOpenAIInvocationParameters" /> class.
        /// </summary>
        public PromptOpenAIInvocationParameters()
        {
        }
    }
}