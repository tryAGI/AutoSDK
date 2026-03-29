//HintName: G.Models.ResearchEventDtoClassVariant3Variant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant3Variant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eventType")]
        public global::G.ResearchEventDtoClassVariant3Variant3EventType EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("planId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PlanId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("taskId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResearchEventDtoClassVariant3Variant3Output Output { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3Variant3" /> class.
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="taskId"></param>
        /// <param name="output"></param>
        /// <param name="createdAt">
        /// Milliseconds since epoch time
        /// </param>
        /// <param name="researchId"></param>
        /// <param name="eventType"></param>
        public ResearchEventDtoClassVariant3Variant3(
            string planId,
            string taskId,
            global::G.ResearchEventDtoClassVariant3Variant3Output output,
            double createdAt,
            string researchId,
            global::G.ResearchEventDtoClassVariant3Variant3EventType eventType)
        {
            this.EventType = eventType;
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.CreatedAt = createdAt;
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3Variant3" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant3Variant3()
        {
        }
    }
}