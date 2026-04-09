//HintName: G.Models.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter))]
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1Discriminator(
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1Discriminator" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1Discriminator()
        {
        }
    }
}