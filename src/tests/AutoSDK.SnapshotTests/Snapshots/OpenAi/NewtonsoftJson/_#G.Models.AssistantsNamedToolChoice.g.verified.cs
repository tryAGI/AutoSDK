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
        public global::G.AssistantsNamedToolChoiceType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.AssistantsNamedToolChoiceFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantsNamedToolChoice" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the tool. If type is `function`, the function name must be set
        /// </param>
        /// <param name="function"></param>
        public AssistantsNamedToolChoice(
            global::G.AssistantsNamedToolChoiceType type,
            global::G.AssistantsNamedToolChoiceFunction? function)
        {
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantsNamedToolChoice" /> class.
        /// </summary>
        public AssistantsNamedToolChoice()
        {
        }
    }
}