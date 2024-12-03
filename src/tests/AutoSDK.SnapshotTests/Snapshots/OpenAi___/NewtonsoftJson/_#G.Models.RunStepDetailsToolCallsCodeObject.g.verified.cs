//HintName: G.Models.RunStepDetailsToolCallsCodeObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the Code Interpreter tool call the run step was involved in.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeObject
    {
        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of tool call. This is always going to be `code_interpreter` for this type of tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDetailsToolCallsCodeObjectType Type { get; set; }

        /// <summary>
        /// The Code Interpreter tool call definition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_interpreter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDetailsToolCallsCodeObjectCodeInterpreter CodeInterpreter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the tool call.
        /// </param>
        /// <param name="type">
        /// The type of tool call. This is always going to be `code_interpreter` for this type of tool call.
        /// </param>
        /// <param name="codeInterpreter">
        /// The Code Interpreter tool call definition.
        /// </param>
        public RunStepDetailsToolCallsCodeObject(
            string id,
            global::G.RunStepDetailsToolCallsCodeObjectCodeInterpreter codeInterpreter,
            global::G.RunStepDetailsToolCallsCodeObjectType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CodeInterpreter = codeInterpreter ?? throw new global::System.ArgumentNullException(nameof(codeInterpreter));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeObject()
        {
        }
    }
}