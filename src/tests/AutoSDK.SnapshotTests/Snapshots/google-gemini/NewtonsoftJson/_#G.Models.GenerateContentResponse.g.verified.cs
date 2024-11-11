//HintName: G.Models.GenerateContentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from the model supporting multiple candidates. Note on safety ratings and content filtering. They are reported for both prompt in `GenerateContentResponse.prompt_feedback` and for each candidate in `finish_reason` and in `safety_ratings`. The API contract is that: - either all requested candidates are returned or no candidates at all - no candidates are returned only if there was something wrong with the prompt (see `prompt_feedback`) - feedback on each candidate is reported on `finish_reason` and `safety_ratings`.
    /// </summary>
    public sealed partial class GenerateContentResponse
    {
        /// <summary>
        /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptFeedback")]
        public global::G.PromptFeedback? PromptFeedback { get; set; }

        /// <summary>
        /// Candidate responses from the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("candidates")]
        public global::System.Collections.Generic.IList<global::G.Candidate>? Candidates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentResponse" /> class.
        /// </summary>
        /// <param name="promptFeedback">
        /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
        /// </param>
        /// <param name="candidates">
        /// Candidate responses from the model.
        /// </param>
        public GenerateContentResponse(
            global::G.PromptFeedback? promptFeedback,
            global::System.Collections.Generic.IList<global::G.Candidate>? candidates)
        {
            this.PromptFeedback = promptFeedback;
            this.Candidates = candidates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentResponse" /> class.
        /// </summary>
        public GenerateContentResponse()
        {
        }
    }
}