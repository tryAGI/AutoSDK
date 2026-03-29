//HintName: G.Models.TrackPromptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackPromptRequest
    {
        /// <summary>
        /// The name of the prompt template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptName { get; set; }

        /// <summary>
        /// Input variables for the prompt template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_input_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? PromptInputVariables { get; set; }

        /// <summary>
        /// The unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestId { get; set; }

        /// <summary>
        /// The version of the prompt template. Both version and label cannot be specified. Only one or none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// The label of the prompt template version. Both version and label cannot be specified. Only one or none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackPromptRequest" /> class.
        /// </summary>
        /// <param name="promptName">
        /// The name of the prompt template.
        /// </param>
        /// <param name="requestId">
        /// The unique identifier for the request.
        /// </param>
        /// <param name="promptInputVariables">
        /// Input variables for the prompt template.
        /// </param>
        /// <param name="version">
        /// The version of the prompt template. Both version and label cannot be specified. Only one or none.
        /// </param>
        /// <param name="label">
        /// The label of the prompt template version. Both version and label cannot be specified. Only one or none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackPromptRequest(
            string promptName,
            int requestId,
            global::System.Collections.Generic.Dictionary<string, string>? promptInputVariables,
            int? version,
            string? label)
        {
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
            this.PromptInputVariables = promptInputVariables;
            this.RequestId = requestId;
            this.Version = version;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackPromptRequest" /> class.
        /// </summary>
        public TrackPromptRequest()
        {
        }
    }
}