//HintName: G.Models.PromptTogetherInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptTogetherInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"together"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "together";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("together", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptTogetherInvocationParametersContent Together { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTogetherInvocationParameters" /> class.
        /// </summary>
        /// <param name="together"></param>
        /// <param name="type"></param>
        public PromptTogetherInvocationParameters(
            global::G.PromptTogetherInvocationParametersContent together,
            string type = "together")
        {
            this.Type = type;
            this.Together = together ?? throw new global::System.ArgumentNullException(nameof(together));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTogetherInvocationParameters" /> class.
        /// </summary>
        public PromptTogetherInvocationParameters()
        {
        }
    }
}