//HintName: G.Models.ResearchEventDtoClassVariant2Variant3OutputVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant2Variant3OutputVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputVariant1OutputTypeJsonConverter))]
        public global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1OutputType OutputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reasoning { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tasksInstructions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TasksInstructions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant3OutputVariant1" /> class.
        /// </summary>
        /// <param name="reasoning"></param>
        /// <param name="tasksInstructions"></param>
        /// <param name="outputType"></param>
        public ResearchEventDtoClassVariant2Variant3OutputVariant1(
            string reasoning,
            global::System.Collections.Generic.IList<string> tasksInstructions,
            global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1OutputType outputType)
        {
            this.OutputType = outputType;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.TasksInstructions = tasksInstructions ?? throw new global::System.ArgumentNullException(nameof(tasksInstructions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant3OutputVariant1" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant2Variant3OutputVariant1()
        {
        }
    }
}