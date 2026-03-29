//HintName: G.Models.GenerateContentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from the model supporting multiple candidate responses. Safety ratings and content filtering are reported for both prompt in `GenerateContentResponse.prompt_feedback` and for each candidate in `finish_reason` and in `safety_ratings`. The API: - Returns either all requested candidates or none of them - Returns no candidates at all only if there was something wrong with the prompt (check `prompt_feedback`) - Reports feedback on each candidate in `finish_reason` and `safety_ratings`.
    /// </summary>
    public sealed partial class GenerateContentResponse
    {
        /// <summary>
        /// Candidate responses from the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("candidates")]
        public global::System.Collections.Generic.IList<global::G.Candidate>? Candidates { get; set; }

        /// <summary>
        /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptFeedback")]
        public global::G.PromptFeedback? PromptFeedback { get; set; }

        /// <summary>
        /// Metadata on the generation request's token usage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usageMetadata")]
        public global::G.UsageMetadata? UsageMetadata { get; set; }

        /// <summary>
        /// Output only. The model version used to generate the response.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelVersion")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// Output only. response_id is used to identify each response.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseId")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The status of the underlying model. This is used to indicate the stage of the underlying model and the retirement time if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelStatus")]
        public global::G.ModelStatus? ModelStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentResponse" /> class.
        /// </summary>
        /// <param name="candidates">
        /// Candidate responses from the model.
        /// </param>
        /// <param name="promptFeedback">
        /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
        /// </param>
        /// <param name="usageMetadata">
        /// Metadata on the generation request's token usage.
        /// </param>
        /// <param name="modelVersion">
        /// Output only. The model version used to generate the response.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="responseId">
        /// Output only. response_id is used to identify each response.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="modelStatus">
        /// The status of the underlying model. This is used to indicate the stage of the underlying model and the retirement time if applicable.
        /// </param>
        public GenerateContentResponse(
            global::System.Collections.Generic.IList<global::G.Candidate>? candidates,
            global::G.PromptFeedback? promptFeedback,
            global::G.UsageMetadata? usageMetadata,
            string? modelVersion,
            string? responseId,
            global::G.ModelStatus? modelStatus)
        {
            this.Candidates = candidates;
            this.PromptFeedback = promptFeedback;
            this.UsageMetadata = usageMetadata;
            this.ModelVersion = modelVersion;
            this.ResponseId = responseId;
            this.ModelStatus = modelStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentResponse" /> class.
        /// </summary>
        public GenerateContentResponse()
        {
        }
    }
}