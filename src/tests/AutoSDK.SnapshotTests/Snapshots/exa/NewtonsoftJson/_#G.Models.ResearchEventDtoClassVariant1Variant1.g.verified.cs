//HintName: G.Models.ResearchEventDtoClassVariant1Variant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant1Variant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eventType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResearchEventDtoClassVariant1Variant1EventTypeJsonConverter))]
        public global::G.ResearchEventDtoClassVariant1Variant1EventType EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Milliseconds since epoch time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public double CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("researchId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResearchId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1Variant1" /> class.
        /// </summary>
        /// <param name="instructions"></param>
        /// <param name="createdAt">
        /// Milliseconds since epoch time
        /// </param>
        /// <param name="researchId"></param>
        /// <param name="eventType"></param>
        /// <param name="outputSchema"></param>
        public ResearchEventDtoClassVariant1Variant1(
            string instructions,
            double createdAt,
            string researchId,
            global::G.ResearchEventDtoClassVariant1Variant1EventType eventType,
            object? outputSchema)
        {
            this.EventType = eventType;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.OutputSchema = outputSchema;
            this.CreatedAt = createdAt;
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1Variant1" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant1Variant1()
        {
        }
    }
}