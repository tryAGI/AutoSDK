//HintName: G.Models.ResearchDtoClassVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassVariant3
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResearchDtoClassVariant3ModelJsonConverter))]
        public global::G.ResearchDtoClassVariant3Model? Model { get; set; }

        /// <summary>
        /// The instructions given to this research request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResearchDtoClassVariant3StatusJsonConverter))]
        public global::G.ResearchDtoClassVariant3Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.ResearchEventDtoClass>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResearchDtoClassVariant3Output Output { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("costDollars", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResearchDtoClassVariant3CostDollars CostDollars { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant3" /> class.
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
        /// <param name="output"></param>
        /// <param name="costDollars"></param>
        /// <param name="model">
        /// The model used for the research request<br/>
        /// Default Value: exa-research
        /// </param>
        /// <param name="status"></param>
        /// <param name="events"></param>
        public ResearchDtoClassVariant3(
            string researchId,
            double createdAt,
            string instructions,
            global::G.ResearchDtoClassVariant3Output output,
            global::G.ResearchDtoClassVariant3CostDollars costDollars,
            global::G.ResearchDtoClassVariant3Model? model,
            global::G.ResearchDtoClassVariant3Status status,
            global::System.Collections.Generic.IList<global::G.ResearchEventDtoClass>? events)
        {
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
            this.CreatedAt = createdAt;
            this.Model = model;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Status = status;
            this.Events = events;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.CostDollars = costDollars ?? throw new global::System.ArgumentNullException(nameof(costDollars));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant3" /> class.
        /// </summary>
        public ResearchDtoClassVariant3()
        {
        }
    }
}