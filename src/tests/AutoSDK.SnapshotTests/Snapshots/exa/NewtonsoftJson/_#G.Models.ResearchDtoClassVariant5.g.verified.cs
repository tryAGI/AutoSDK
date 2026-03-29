//HintName: G.Models.ResearchDtoClassVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassVariant5
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
        public global::G.ResearchDtoClassVariant5Model? Model { get; set; }

        /// <summary>
        /// The instructions given to this research request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ResearchDtoClassVariant5Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.ResearchEventDtoClass>? Events { get; set; }

        /// <summary>
        /// A message indicating why the request failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant5" /> class.
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
        /// <param name="error">
        /// A message indicating why the request failed
        /// </param>
        /// <param name="model">
        /// The model used for the research request<br/>
        /// Default Value: exa-research
        /// </param>
        /// <param name="status"></param>
        /// <param name="events"></param>
        public ResearchDtoClassVariant5(
            string researchId,
            double createdAt,
            string instructions,
            string error,
            global::G.ResearchDtoClassVariant5Model? model,
            global::G.ResearchDtoClassVariant5Status status,
            global::System.Collections.Generic.IList<global::G.ResearchEventDtoClass>? events)
        {
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
            this.CreatedAt = createdAt;
            this.Model = model;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Status = status;
            this.Events = events;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant5" /> class.
        /// </summary>
        public ResearchDtoClassVariant5()
        {
        }
    }
}