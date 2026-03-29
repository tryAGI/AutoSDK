//HintName: G.Models.GetRequestResponsePromptBlueprint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The request converted to a prompt blueprint format.
    /// </summary>
    public sealed partial class GetRequestResponsePromptBlueprint
    {
        /// <summary>
        /// The prompt template with type and messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public object? PromptTemplate { get; set; }

        /// <summary>
        /// Metadata including model provider, name, and parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The inference client name if one was used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inference_client_name")]
        public string? InferenceClientName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestResponsePromptBlueprint" /> class.
        /// </summary>
        /// <param name="promptTemplate">
        /// The prompt template with type and messages.
        /// </param>
        /// <param name="metadata">
        /// Metadata including model provider, name, and parameters.
        /// </param>
        /// <param name="inferenceClientName">
        /// The inference client name if one was used.
        /// </param>
        public GetRequestResponsePromptBlueprint(
            object? promptTemplate,
            object? metadata,
            string? inferenceClientName)
        {
            this.PromptTemplate = promptTemplate;
            this.Metadata = metadata;
            this.InferenceClientName = inferenceClientName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestResponsePromptBlueprint" /> class.
        /// </summary>
        public GetRequestResponsePromptBlueprint()
        {
        }
    }
}