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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of the code interpreter tool call. Always `code_interpreter_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeInterpreterToolCallTypeJsonConverter))]
        public global::G.CodeInterpreterToolCallType Type { get; set; }

        /// <summary>
        /// The ID of the container used to run the code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        public string? ContainerId { get; set; }

        /// <summary>
        /// The code to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The status of the code interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeInterpreterToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodeInterpreterToolCallStatus Status { get; set; }

        /// <summary>
        /// The results of the code interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CodeInterpreterToolOutput> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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