//HintName: G.Models.OpenAIBatchesIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIBatchesIn
    {
        /// <summary>
        /// The ID of an uploaded file that contains requests for the new batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputFileId { get; set; } = default!;

        /// <summary>
        /// The endpoint to be used for all requests in the batch. Currently /v1/chat/completions, /v1/completions are supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIBatchesInEndpoint Endpoint { get; set; } = default!;

        /// <summary>
        /// The time frame within which the batch should be processed. Currently only 24h is supported.
        /// </summary>
        /// <default>"24h"</default>
        [global::Newtonsoft.Json.JsonProperty("completion_window")]
        public string CompletionWindow { get; set; } = "24h";

        /// <summary>
        /// Optional metadata to be stored with the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIBatchesIn" /> class.
        /// </summary>
        /// <param name="inputFileId">
        /// The ID of an uploaded file that contains requests for the new batch.
        /// </param>
        /// <param name="endpoint">
        /// The endpoint to be used for all requests in the batch. Currently /v1/chat/completions, /v1/completions are supported.
        /// </param>
        /// <param name="completionWindow">
        /// The time frame within which the batch should be processed. Currently only 24h is supported.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata to be stored with the batch.
        /// </param>
        public OpenAIBatchesIn(
            string inputFileId,
            global::G.OpenAIBatchesInEndpoint endpoint,
            object? metadata,
            string completionWindow = "24h")
        {
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.Endpoint = endpoint;
            this.CompletionWindow = completionWindow;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIBatchesIn" /> class.
        /// </summary>
        public OpenAIBatchesIn()
        {
        }
    }
}