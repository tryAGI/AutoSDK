//HintName: G.Models.CodeExecutionResultContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result from a code execution tool.
    /// </summary>
    public sealed partial class CodeExecutionResultContent
    {
        /// <summary>
        /// Default Value: code_execution_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeExecutionResultContentTypeJsonConverter))]
        public global::G.CodeExecutionResultContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Output { get; set; }

        /// <summary>
        /// Default Value: OUTCOME_OK
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        public string? Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionResultContent" /> class.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="type">
        /// Default Value: code_execution_result
        /// </param>
        /// <param name="outcome">
        /// Default Value: OUTCOME_OK
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeExecutionResultContent(
            string output,
            global::G.CodeExecutionResultContentType? type,
            string? outcome)
        {
            this.Type = type;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionResultContent" /> class.
        /// </summary>
        public CodeExecutionResultContent()
        {
        }
    }
}