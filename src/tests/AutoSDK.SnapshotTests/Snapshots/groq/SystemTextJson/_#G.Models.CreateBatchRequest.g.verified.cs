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
        /// The ID of an uploaded file that contains requests for the new batch.<br/>
        /// See [upload file](/docs/api-reference#files-upload) for how to upload a file.<br/>
        /// Your input file must be formatted as a [JSONL file](/docs/batch), and must be uploaded with the purpose `batch`. The file can be up to 100 MB in size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputFileId { get; set; }

        /// <summary>
        /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateBatchRequestEndpointJsonConverter))]
        public global::G.CreateBatchRequestEndpoint Endpoint { get; set; }

        /// <summary>
        /// The time frame within which the batch should be processed. Durations from `24h` to `7d` are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompletionWindow { get; set; }

        /// <summary>
        /// Optional custom metadata for the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        /// <param name="inputFileId">
        /// The ID of an uploaded file that contains requests for the new batch.<br/>
        /// See [upload file](/docs/api-reference#files-upload) for how to upload a file.<br/>
        /// Your input file must be formatted as a [JSONL file](/docs/batch), and must be uploaded with the purpose `batch`. The file can be up to 100 MB in size.
        /// </param>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed. Durations from `24h` to `7d` are supported.
        /// </param>
        /// <param name="endpoint">
        /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions` is supported.
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata for the batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBatchRequest(
            string inputFileId,
            string completionWindow,
            global::G.CreateBatchRequestEndpoint endpoint,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.Endpoint = endpoint;
            this.CompletionWindow = completionWindow ?? throw new global::System.ArgumentNullException(nameof(completionWindow));
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