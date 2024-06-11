//HintName: G.Models.CreateBatchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBatchRequest
    {
        /// <summary>
        /// The ID of an uploaded file that contains requests for the new batch.
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.
        /// Your input file must be formatted as a [JSONL file](/docs/api-reference/batch/requestInput), and must be uploaded with the purpose `batch`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputFileId { get; set; } = default!;

        /// <summary>
        /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions` and `/v1/embeddings` are supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateBatchRequestEndpoint Endpoint { get; set; } = default!;

        /// <summary>
        /// The time frame within which the batch should be processed. Currently only `24h` is supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_window", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateBatchRequestCompletionWindow CompletionWindow { get; set; } = default!;

        /// <summary>
        /// Optional custom metadata for the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}