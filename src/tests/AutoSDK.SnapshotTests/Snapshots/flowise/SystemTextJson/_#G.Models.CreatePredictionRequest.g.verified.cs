//HintName: G.Models.CreatePredictionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionRequest
    {
        /// <summary>
        /// Question/message to send to the flow<br/>
        /// Example: Analyze this uploaded file and summarize its contents
        /// </summary>
        /// <example>Analyze this uploaded file and summarize its contents</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        /// Files to be uploaded (images, audio, documents, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<byte[]>? Files { get; set; }

        /// <summary>
        /// Enable streaming responses<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// JSON string of configuration overrides<br/>
        /// Example: {"sessionId":"user-123","temperature":0.7}
        /// </summary>
        /// <example>{"sessionId":"user-123","temperature":0.7}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrideConfig")]
        public string? OverrideConfig { get; set; }

        /// <summary>
        /// JSON string of conversation history<br/>
        /// Example: [{"role":"userMessage","content":"Hello"},{"role":"apiMessage","content":"Hi there!"}]
        /// </summary>
        /// <example>[{"role":"userMessage","content":"Hello"},{"role":"apiMessage","content":"Hi there!"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public string? History { get; set; }

        /// <summary>
        /// JSON string of human input for resuming execution<br/>
        /// Example: {"type":"proceed","feedback":"Continue with the plan"}
        /// </summary>
        /// <example>{"type":"proceed","feedback":"Continue with the plan"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("humanInput")]
        public string? HumanInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionRequest" /> class.
        /// </summary>
        /// <param name="question">
        /// Question/message to send to the flow<br/>
        /// Example: Analyze this uploaded file and summarize its contents
        /// </param>
        /// <param name="files">
        /// Files to be uploaded (images, audio, documents, etc.)
        /// </param>
        /// <param name="streaming">
        /// Enable streaming responses<br/>
        /// Default Value: false
        /// </param>
        /// <param name="overrideConfig">
        /// JSON string of configuration overrides<br/>
        /// Example: {"sessionId":"user-123","temperature":0.7}
        /// </param>
        /// <param name="history">
        /// JSON string of conversation history<br/>
        /// Example: [{"role":"userMessage","content":"Hello"},{"role":"apiMessage","content":"Hi there!"}]
        /// </param>
        /// <param name="humanInput">
        /// JSON string of human input for resuming execution<br/>
        /// Example: {"type":"proceed","feedback":"Continue with the plan"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePredictionRequest(
            string question,
            global::System.Collections.Generic.IList<byte[]>? files,
            bool? streaming,
            string? overrideConfig,
            string? history,
            string? humanInput)
        {
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.Files = files;
            this.Streaming = streaming;
            this.OverrideConfig = overrideConfig;
            this.History = history;
            this.HumanInput = humanInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionRequest" /> class.
        /// </summary>
        public CreatePredictionRequest()
        {
        }
    }
}