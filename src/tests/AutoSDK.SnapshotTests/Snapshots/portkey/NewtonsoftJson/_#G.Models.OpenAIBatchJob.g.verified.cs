//HintName: G.Models.OpenAIBatchJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gateway supported body params for OpenAI, Azure OpenAI and VertexAI.
    /// </summary>
    public sealed partial class OpenAIBatchJob
    {
        /// <summary>
        /// The input file to use for the batch job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputFileId { get; set; } = default!;

        /// <summary>
        /// Completion window for the batch job, `immediate` is only supported with Portkey Managed Batching.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_window", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIBatchJobCompletionWindow CompletionWindow { get; set; } = default!;

        /// <summary>
        /// Inference endpoint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIBatchJobEndpoint Endpoint { get; set; } = default!;

        /// <summary>
        /// metadata related for the batch job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIBatchJob" /> class.
        /// </summary>
        /// <param name="inputFileId">
        /// The input file to use for the batch job
        /// </param>
        /// <param name="completionWindow">
        /// Completion window for the batch job, `immediate` is only supported with Portkey Managed Batching.
        /// </param>
        /// <param name="endpoint">
        /// Inference endpoint
        /// </param>
        /// <param name="metadata">
        /// metadata related for the batch job
        /// </param>
        public OpenAIBatchJob(
            string inputFileId,
            global::G.OpenAIBatchJobCompletionWindow completionWindow,
            global::G.OpenAIBatchJobEndpoint endpoint,
            object? metadata)
        {
            this.InputFileId = inputFileId ?? throw new global::System.ArgumentNullException(nameof(inputFileId));
            this.CompletionWindow = completionWindow;
            this.Endpoint = endpoint;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIBatchJob" /> class.
        /// </summary>
        public OpenAIBatchJob()
        {
        }
    }
}