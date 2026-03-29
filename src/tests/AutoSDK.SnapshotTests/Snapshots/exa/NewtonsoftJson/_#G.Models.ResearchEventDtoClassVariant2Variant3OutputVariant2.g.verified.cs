//HintName: G.Models.ResearchEventDtoClassVariant2Variant3OutputVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant2Variant3OutputVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputType")]
        public global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType OutputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reasoning { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant3OutputVariant2" /> class.
        /// </summary>
        /// <param name="reasoning"></param>
        /// <param name="outputType"></param>
        public ResearchEventDtoClassVariant2Variant3OutputVariant2(
            string reasoning,
            global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType outputType)
        {
            this.OutputType = outputType;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant3OutputVariant2" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant2Variant3OutputVariant2()
        {
        }
    }
}