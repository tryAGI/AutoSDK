//HintName: G.Models.AssistantsNamedToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies a tool the model should use. Use to force the model to call a specific tool.
    /// </summary>
    public sealed partial class AssistantsNamedToolChoice
    {
        /// <summary>
        /// The type of the tool. If type is `function`, the function name must be set
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public AssistantsNamedToolChoiceType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public AssistantsNamedToolChoiceFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}