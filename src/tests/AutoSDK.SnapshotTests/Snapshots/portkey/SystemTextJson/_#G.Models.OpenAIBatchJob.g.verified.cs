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
        [global::System.Text.Json.Serialization.JsonPropertyName("input_file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputFileId { get; set; }

        /// <summary>
        /// Completion window for the batch job, `immediate` is only supported with Portkey Managed Batching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAIBatchJobCompletionWindowJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIBatchJobCompletionWindow CompletionWindow { get; set; }

        /// <summary>
        /// Inference endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAIBatchJobEndpointJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIBatchJobEndpoint Endpoint { get; set; }

        /// <summary>
        /// metadata related for the batch job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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