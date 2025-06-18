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
        /// The unique ID of the code interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of the code interpreter tool call. Always `code_interpreter_call`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodeInterpreterToolCallType Type { get; set; }

        /// <summary>
        /// The ID of the container used to run the code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container_id")]
        public string? ContainerId { get; set; }

        /// <summary>
        /// The code to run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// The status of the code interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeInterpreterToolCallStatus Status { get; set; } = default!;

        /// <summary>
        /// The results of the code interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CodeInterpreterToolOutput> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the code interpreter tool call.
        /// </param>
        /// <param name="type">
        /// The type of the code interpreter tool call. Always `code_interpreter_call`.
        /// </param>
        /// <param name="containerId">
        /// The ID of the container used to run the code.
        /// </param>
        /// <param name="code">
        /// The code to run.
        /// </param>
        /// <param name="status">
        /// The status of the code interpreter tool call.
        /// </param>
        /// <param name="results">
        /// The results of the code interpreter tool call.
        /// </param>
        public CodeInterpreterToolCall(
            string id,
            string code,
            global::G.CodeInterpreterToolCallStatus status,
            global::System.Collections.Generic.IList<global::G.CodeInterpreterToolOutput> results,
            global::G.CodeInterpreterToolCallType type,
            string? containerId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Status = status;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Type = type;
            this.ContainerId = containerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolCall" /> class.
        /// </summary>
        public CodeInterpreterToolCall()
        {
        }
    }
}