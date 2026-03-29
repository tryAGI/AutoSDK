//HintName: G.Models.GuardrailConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailConfig
    {
        /// <summary>
        /// Selected prohibited agent topic categories to check. When agent messages contain these topics, they will be replaced with a placeholder message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_topics")]
        public global::System.Collections.Generic.IList<global::G.GuardrailConfigOutputTopic>? OutputTopics { get; set; }

        /// <summary>
        /// Selected prohibited user topic categories to check. When user messages contain these topics, the agent will respond with a placeholder message instead of processing the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_topics")]
        public global::System.Collections.Generic.IList<global::G.GuardrailConfigInputTopic>? InputTopics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailConfig" /> class.
        /// </summary>
        /// <param name="outputTopics">
        /// Selected prohibited agent topic categories to check. When agent messages contain these topics, they will be replaced with a placeholder message.
        /// </param>
        /// <param name="inputTopics">
        /// Selected prohibited user topic categories to check. When user messages contain these topics, the agent will respond with a placeholder message instead of processing the request.
        /// </param>
        public GuardrailConfig(
            global::System.Collections.Generic.IList<global::G.GuardrailConfigOutputTopic>? outputTopics,
            global::System.Collections.Generic.IList<global::G.GuardrailConfigInputTopic>? inputTopics)
        {
            this.OutputTopics = outputTopics;
            this.InputTopics = inputTopics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailConfig" /> class.
        /// </summary>
        public GuardrailConfig()
        {
        }
    }
}