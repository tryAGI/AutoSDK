//HintName: G.Models.ResearchDtoClassVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassVariant1
    {
        /// <summary>
        /// The unique identifier for the research request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("researchId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResearchId { get; set; } = default!;

        /// <summary>
        /// Milliseconds since epoch time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public double CreatedAt { get; set; } = default!;

        /// <summary>
        /// The model used for the research request<br/>
        /// Default Value: exa-research
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.ResearchDtoClassVariant1Model? Model { get; set; }

        /// <summary>
        /// The instructions given to this research request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ResearchDtoClassVariant1Status Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant1" /> class.
        /// </summary>
        /// <param name="researchId">
        /// The unique identifier for the research request
        /// </param>
        /// <param name="createdAt">
        /// Milliseconds since epoch time
        /// </param>
        /// <param name="instructions">
        /// The instructions given to this research request
        /// </param>
        /// <param name="model">
        /// The model used for the research request<br/>
        /// Default Value: exa-research
        /// </param>
        /// <param name="status"></param>
        public ResearchDtoClassVariant1(
            string researchId,
            double createdAt,
            string instructions,
            global::G.ResearchDtoClassVariant1Model? model,
            global::G.ResearchDtoClassVariant1Status status)
        {
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
            this.CreatedAt = createdAt;
            this.Model = model;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant1" /> class.
        /// </summary>
        public ResearchDtoClassVariant1()
        {
        }
    }
}