//HintName: G.Models.CodeInterpreterToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool call to run code.
    /// </summary>
    public sealed partial class CodeInterpreterToolCall
    {
        /// <summary>
        /// The code to run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// The unique ID of the code interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The results of the code interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CodeInterpreterToolOutput> Results { get; set; } = default!;

        /// <summary>
        /// The status of the code interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeInterpreterToolCallStatus Status { get; set; } = default!;

        /// <summary>
        /// The type of the code interpreter tool call. Always `code_interpreter_call`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodeInterpreterToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolCall" /> class.
        /// </summary>
        /// <param name="code">
        /// The code to run.
        /// </param>
        /// <param name="id">
        /// The unique ID of the code interpreter tool call.
        /// </param>
        /// <param name="results">
        /// The results of the code interpreter tool call.
        /// </param>
        /// <param name="status">
        /// The status of the code interpreter tool call.
        /// </param>
        /// <param name="type">
        /// The type of the code interpreter tool call. Always `code_interpreter_call`.
        /// </param>
        public CodeInterpreterToolCall(
            string code,
            string id,
            global::System.Collections.Generic.IList<global::G.CodeInterpreterToolOutput> results,
            global::G.CodeInterpreterToolCallStatus status,
            global::G.CodeInterpreterToolCallType type)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolCall" /> class.
        /// </summary>
        public CodeInterpreterToolCall()
        {
        }
    }
}