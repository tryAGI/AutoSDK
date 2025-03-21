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
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The unique ID of the code interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The results of the code interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CodeInterpreterToolOutput> Results { get; set; }

        /// <summary>
        /// The status of the code interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeInterpreterToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodeInterpreterToolCallStatus Status { get; set; }

        /// <summary>
        /// The type of the code interpreter tool call. Always `code_interpreter_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeInterpreterToolCallTypeJsonConverter))]
        public global::G.CodeInterpreterToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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