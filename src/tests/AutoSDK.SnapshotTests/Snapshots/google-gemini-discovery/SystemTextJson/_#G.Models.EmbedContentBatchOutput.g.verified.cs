//HintName: G.Models.EmbedContentBatchOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output of a batch request. This is returned in the `AsyncBatchEmbedContentResponse` or the `EmbedContentBatch.output` field.
    /// </summary>
    public sealed partial class EmbedContentBatchOutput
    {
        /// <summary>
        /// Output only. The file ID of the file containing the responses. The file will be a JSONL file with a single response per line. The responses will be `EmbedContentResponse` messages formatted as JSON. The responses will be written in the same order as the input requests.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responsesFile")]
        public string? ResponsesFile { get; set; }

        /// <summary>
        /// The responses to the requests in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inlinedResponses")]
        public global::G.InlinedEmbedContentResponses? InlinedResponses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedContentBatchOutput" /> class.
        /// </summary>
        /// <param name="responsesFile">
        /// Output only. The file ID of the file containing the responses. The file will be a JSONL file with a single response per line. The responses will be `EmbedContentResponse` messages formatted as JSON. The responses will be written in the same order as the input requests.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inlinedResponses">
        /// The responses to the requests in the batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedContentBatchOutput(
            string? responsesFile,
            global::G.InlinedEmbedContentResponses? inlinedResponses)
        {
            this.ResponsesFile = responsesFile;
            this.InlinedResponses = inlinedResponses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedContentBatchOutput" /> class.
        /// </summary>
        public EmbedContentBatchOutput()
        {
        }
    }
}