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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::G.AssistantsNamedToolChoiceFunction? Function { get; set; }

        /// <summary>
        /// The type of the tool. If type is `function`, the function name must be set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantsNamedToolChoiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssistantsNamedToolChoiceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantsNamedToolChoice" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type">
        /// The type of the tool. If type is `function`, the function name must be set
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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