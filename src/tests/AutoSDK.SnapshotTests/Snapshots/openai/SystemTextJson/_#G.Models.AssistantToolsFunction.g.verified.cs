//HintName: G.Models.AssistantToolsFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantToolsFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FunctionObject Function { get; set; }

        /// <summary>
        /// The type of tool being defined: `function`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantToolsFunctionTypeJsonConverter))]
        public global::G.AssistantToolsFunctionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFunction" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type">
        /// The type of tool being defined: `function`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantToolsFunction(
            global::G.FunctionObject function,
            global::G.AssistantToolsFunctionType type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFunction" /> class.
        /// </summary>
        public AssistantToolsFunction()
        {
        }
    }
}