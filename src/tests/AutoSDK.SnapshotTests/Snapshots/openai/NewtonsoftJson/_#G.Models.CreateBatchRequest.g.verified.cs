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
        /// The time frame within which the batch should be processed. Currently only `24h` is supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_window")]
        public global::G.CreateBatchRequestCompletionWindow CompletionWindow { get; set; }

        /// <summary>
        /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions`, `/v1/embeddings`, and `/v1/completions` are supported. Note that `/v1/embeddings` batches are also restricted to a maximum of 50,000 embedding inputs across all requests in the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateBatchRequestEndpoint Endpoint { get; set; } = default!;

        /// <summary>
        /// The ID of an uploaded file that contains requests for the new batch.<br/>
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.<br/>
        /// Your input file must be formatted as a [JSONL file](/docs/api-reference/batch/request-input), and must be uploaded with the purpose `batch`. The file can contain up to 50,000 requests, and can be up to 200 MB in size.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputFileId { get; set; } = default!;

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed. Currently only `24h` is supported.
        /// </param>
        /// <param name="endpoint">
        /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions`, `/v1/embeddings`, and `/v1/completions` are supported. Note that `/v1/embeddings` batches are also restricted to a maximum of 50,000 embedding inputs across all requests in the batch.
        /// </param>
        /// <param name="inputFileId">
        /// The ID of an uploaded file that contains requests for the new batch.<br/>
        /// See [upload file](/docs/api-reference/files/create) for how to upload a file.<br/>
        /// Your input file must be formatted as a [JSONL file](/docs/api-reference/batch/request-input), and must be uploaded with the purpose `batch`. The file can contain up to 50,000 requests, and can be up to 200 MB in size.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        public CreateBatchRequest(
            global::G.CreateBatchRequestEndpoint endpoint,
            string inputFileId,
            global::G.CreateBatchRequestCompletionWindow completionWindow,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Endpoint = endpoint;
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.CompletionWindow = completionWindow;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        public CreateBatchRequest()
        {
        }
    }
}