//HintName: G.Models.CodeExecutionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result of executing the `ExecutableCode`. Generated only when the `CodeExecution` tool is used.
    /// </summary>
    public sealed partial class CodeExecutionResult
    {
        /// <summary>
        /// Optional. The identifier of the `ExecutableCode` part this result is for. Only populated if the corresponding `ExecutableCode` has an id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Required. Outcome of the code execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outcome")]
        public global::G.CodeExecutionResultOutcome? Outcome { get; set; }

        /// <summary>
        /// Optional. Contains stdout when code execution is successful, stderr or other description otherwise.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionResult" /> class.
        /// </summary>
        /// <param name="id">
        /// Optional. The identifier of the `ExecutableCode` part this result is for. Only populated if the corresponding `ExecutableCode` has an id.
        /// </param>
        /// <param name="outcome">
        /// Required. Outcome of the code execution.
        /// </param>
        /// <param name="output">
        /// Optional. Contains stdout when code execution is successful, stderr or other description otherwise.
        /// </param>
        public CodeExecutionResult(
            string? id,
            global::G.CodeExecutionResultOutcome? outcome,
            string? output)
        {
            this.Id = id;
            this.Outcome = outcome;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionResult" /> class.
        /// </summary>
        public CodeExecutionResult()
        {
        }
    }
}