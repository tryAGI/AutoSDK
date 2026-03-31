//HintName: G.Models.ResearchEventDtoClassVariant1Variant2OutputVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant1Variant2OutputVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputVariant2OutputTypeJsonConverter))]
        public global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2OutputType OutputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1Variant2OutputVariant2" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="outputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant1Variant2OutputVariant2(
            string error,
            global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2OutputType outputType)
        {
            this.OutputType = outputType;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1Variant2OutputVariant2" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant1Variant2OutputVariant2()
        {
        }
    }
}