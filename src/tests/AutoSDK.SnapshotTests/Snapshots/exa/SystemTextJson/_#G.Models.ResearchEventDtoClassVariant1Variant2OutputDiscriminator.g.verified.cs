//HintName: G.Models.ResearchEventDtoClassVariant1Variant2OutputDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant1Variant2OutputDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        public string? OutputType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1Variant2OutputDiscriminator" /> class.
        /// </summary>
        /// <param name="outputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant1Variant2OutputDiscriminator(
            string? outputType)
        {
            this.OutputType = outputType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1Variant2OutputDiscriminator" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant1Variant2OutputDiscriminator()
        {
        }
    }
}