//HintName: G.Models.PromptDeepSeekInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptDeepSeekInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"deepseek"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "deepseek";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deepseek", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptDeepSeekInvocationParametersContent Deepseek { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeepSeekInvocationParameters" /> class.
        /// </summary>
        /// <param name="deepseek"></param>
        /// <param name="type"></param>
        public PromptDeepSeekInvocationParameters(
            global::G.PromptDeepSeekInvocationParametersContent deepseek,
            string type = "deepseek")
        {
            this.Type = type;
            this.Deepseek = deepseek ?? throw new global::System.ArgumentNullException(nameof(deepseek));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeepSeekInvocationParameters" /> class.
        /// </summary>
        public PromptDeepSeekInvocationParameters()
        {
        }
    }
}