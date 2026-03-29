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
        [global::Newtonsoft.Json.JsonProperty("prompt_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptName { get; set; } = default!;

        /// <summary>
        /// Input variables for the prompt template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_input_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? PromptInputVariables { get; set; }

        /// <summary>
        /// The unique identifier for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; } = default!;

        /// <summary>
        /// The version of the prompt template. Both version and label cannot be specified. Only one or none.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public int? Version { get; set; }

        /// <summary>
        /// The label of the prompt template version. Both version and label cannot be specified. Only one or none.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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