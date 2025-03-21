//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the Code Interpreter tool call the run step was involved in.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsCodeObject
    {
        /// <summary>
        /// The Code Interpreter tool call definition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_interpreter")]
        public global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? CodeInterpreter { get; set; }

        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The index of the tool call in the tool calls array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The type of tool call. This is always going to be `code_interpreter` for this type of tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDeltaStepDetailsToolCallsCodeObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeObject" /> class.
        /// </summary>
        /// <param name="codeInterpreter">
        /// The Code Interpreter tool call definition.
        /// </param>
        /// <param name="id">
        /// The ID of the tool call.
        /// </param>
        /// <param name="index">
        /// The index of the tool call in the tool calls array.
        /// </param>
        /// <param name="type">
        /// The type of tool call. This is always going to be `code_interpreter` for this type of tool call.
        /// </param>
        public RunStepDeltaStepDetailsToolCallsCodeObject(
            int index,
            global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter? codeInterpreter,
            string? id,
            global::G.RunStepDeltaStepDetailsToolCallsCodeObjectType type)
        {
            this.Index = index;
            this.CodeInterpreter = codeInterpreter;
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeObject()
        {
        }
    }
}