//HintName: G.Models.PromptXAIInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptXAIInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"xai"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "xai";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("xai", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptXAIInvocationParametersContent Xai { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptXAIInvocationParameters" /> class.
        /// </summary>
        /// <param name="xai"></param>
        /// <param name="type"></param>
        public PromptXAIInvocationParameters(
            global::G.PromptXAIInvocationParametersContent xai,
            string type = "xai")
        {
            this.Type = type;
            this.Xai = xai ?? throw new global::System.ArgumentNullException(nameof(xai));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptXAIInvocationParameters" /> class.
        /// </summary>
        public PromptXAIInvocationParameters()
        {
        }
    }
}