//HintName: G.Models.RefinedPromptResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RefinedPromptResponse
    {
        /// <summary>
        /// Previous version of the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_version")]
        public global::G.ThirdPartyModelVersion? PreviousVersion { get; set; }

        /// <summary>
        /// The refined prompt text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Reasoning behind the refinement
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Unique identifier for the refinement job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refinement_job_id")]
        public string? RefinementJobId { get; set; }

        /// <summary>
        /// Status of the refinement job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refinement_status")]
        public string? RefinementStatus { get; set; }

        /// <summary>
        /// Title of the refined prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Total cost of the refinement job (in USD)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost")]
        public string? TotalCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefinedPromptResponse" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The refined prompt text
        /// </param>
        /// <param name="previousVersion">
        /// Previous version of the prompt
        /// </param>
        /// <param name="reasoning">
        /// Reasoning behind the refinement
        /// </param>
        /// <param name="refinementJobId">
        /// Unique identifier for the refinement job
        /// </param>
        /// <param name="refinementStatus">
        /// Status of the refinement job
        /// </param>
        /// <param name="title">
        /// Title of the refined prompt
        /// </param>
        /// <param name="totalCost">
        /// Total cost of the refinement job (in USD)
        /// </param>
        public RefinedPromptResponse(
            string prompt,
            global::G.ThirdPartyModelVersion? previousVersion,
            string? reasoning,
            string? refinementJobId,
            string? refinementStatus,
            string? title,
            string? totalCost)
        {
            this.PreviousVersion = previousVersion;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Reasoning = reasoning;
            this.RefinementJobId = refinementJobId;
            this.RefinementStatus = refinementStatus;
            this.Title = title;
            this.TotalCost = totalCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefinedPromptResponse" /> class.
        /// </summary>
        public RefinedPromptResponse()
        {
        }
    }
}