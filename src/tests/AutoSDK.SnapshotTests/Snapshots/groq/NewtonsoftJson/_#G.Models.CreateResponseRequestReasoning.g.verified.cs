//HintName: G.Models.CreateResponseRequestReasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for reasoning capabilities when using [models that support reasoning](https://console.groq.com/docs/reasoning).
    /// </summary>
    public sealed partial class CreateResponseRequestReasoning
    {
        /// <summary>
        /// Level of reasoning effort. Supported values: `low`, `medium`, `high`. Lower values provide faster responses with less reasoning depth.<br/>
        /// Default Value: medium
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effort")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateResponseRequestReasoningEffortJsonConverter))]
        public global::G.CreateResponseRequestReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequestReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Level of reasoning effort. Supported values: `low`, `medium`, `high`. Lower values provide faster responses with less reasoning depth.<br/>
        /// Default Value: medium
        /// </param>
        public CreateResponseRequestReasoning(
            global::G.CreateResponseRequestReasoningEffort? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseRequestReasoning" /> class.
        /// </summary>
        public CreateResponseRequestReasoning()
        {
        }
    }
}