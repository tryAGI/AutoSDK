//HintName: G.Models.ResearchEventDtoClassVariant2Variant3OutputDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant2Variant3OutputDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputTypeJsonConverter))]
        public global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType? OutputType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant3OutputDiscriminator" /> class.
        /// </summary>
        /// <param name="outputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant2Variant3OutputDiscriminator(
            global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType? outputType)
        {
            this.OutputType = outputType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2Variant3OutputDiscriminator" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant2Variant3OutputDiscriminator()
        {
        }

    }
}