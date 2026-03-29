//HintName: G.Models.PromptCerebrasInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCerebrasInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"cerebras"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "cerebras";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cerebras", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptCerebrasInvocationParametersContent Cerebras { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCerebrasInvocationParameters" /> class.
        /// </summary>
        /// <param name="cerebras"></param>
        /// <param name="type"></param>
        public PromptCerebrasInvocationParameters(
            global::G.PromptCerebrasInvocationParametersContent cerebras,
            string type = "cerebras")
        {
            this.Type = type;
            this.Cerebras = cerebras ?? throw new global::System.ArgumentNullException(nameof(cerebras));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCerebrasInvocationParameters" /> class.
        /// </summary>
        public PromptCerebrasInvocationParameters()
        {
        }
    }
}