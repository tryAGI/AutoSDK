//HintName: G.Models.AudioUrlInputChunkGeneratedMetadataVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioUrlInputChunkGeneratedMetadataVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter))]
        public global::G.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioUrlInputChunkGeneratedMetadataVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioUrlInputChunkGeneratedMetadataVariant1Discriminator(
            global::G.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioUrlInputChunkGeneratedMetadataVariant1Discriminator" /> class.
        /// </summary>
        public AudioUrlInputChunkGeneratedMetadataVariant1Discriminator()
        {
        }
    }
}