//HintName: G.Models.ElevenLabsGeneratedAssetOptionsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElevenLabsGeneratedAssetOptionsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ElevenLabsGeneratedAssetOptionsDiscriminatorTypeJsonConverter))]
        public global::G.ElevenLabsGeneratedAssetOptionsDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsGeneratedAssetOptionsDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsGeneratedAssetOptionsDiscriminator(
            global::G.ElevenLabsGeneratedAssetOptionsDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsGeneratedAssetOptionsDiscriminator" /> class.
        /// </summary>
        public ElevenLabsGeneratedAssetOptionsDiscriminator()
        {
        }
    }
}