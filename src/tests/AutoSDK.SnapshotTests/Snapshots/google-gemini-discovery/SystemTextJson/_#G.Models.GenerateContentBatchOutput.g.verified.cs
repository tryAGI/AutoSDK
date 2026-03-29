//HintName: G.Models.GenerateContentBatchOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output of a batch request. This is returned in the `BatchGenerateContentResponse` or the `GenerateContentBatch.output` field.
    /// </summary>
    public sealed partial class GenerateContentBatchOutput
    {
        /// <summary>
        /// Output only. The file ID of the file containing the responses. The file will be a JSONL file with a single response per line. The responses will be `GenerateContentResponse` messages formatted as JSON. The responses will be written in the same order as the input requests.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responsesFile")]
        public string? ResponsesFile { get; set; }

        /// <summary>
        /// The responses to the requests in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inlinedResponses")]
        public global::G.InlinedResponses? InlinedResponses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentBatchOutput" /> class.
        /// </summary>
        /// <param name="responsesFile">
        /// Output only. The file ID of the file containing the responses. The file will be a JSONL file with a single response per line. The responses will be `GenerateContentResponse` messages formatted as JSON. The responses will be written in the same order as the input requests.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inlinedResponses">
        /// The responses to the requests in the batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateContentBatchOutput(
            string? responsesFile,
            global::G.InlinedResponses? inlinedResponses)
        {
            this.ResponsesFile = responsesFile;
            this.InlinedResponses = inlinedResponses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentBatchOutput" /> class.
        /// </summary>
        public GenerateContentBatchOutput()
        {
        }
    }
}