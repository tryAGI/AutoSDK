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
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputVariant2OutputTypeJsonConverter))]
        public global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2OutputType OutputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant3OutputVariant2" /> class.
        /// </summary>
        /// <param name="reasoning"></param>
        /// <param name="outputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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