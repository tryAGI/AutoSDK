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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CodeExecutionResultContentTypeJsonConverter))]
        public global::G.CodeExecutionResultContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public string Output { get; set; } = default!;

        /// <summary>
        /// Default Value: OUTCOME_OK
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outcome")]
        public string? Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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