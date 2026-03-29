//HintName: G.Models.EmbeddingMultiInputMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for multi-input embeddings
    /// </summary>
    public sealed partial class EmbeddingMultiInputMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingMultiInputMetadataInputTypeJsonConverter))]
        public global::G.EmbeddingMultiInputMetadataInputType InputType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingMultiInputMetadata" /> class.
        /// </summary>
        /// <param name="inputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingMultiInputMetadata(
            global::G.EmbeddingMultiInputMetadataInputType inputType)
        {
            this.InputType = inputType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingMultiInputMetadata" /> class.
        /// </summary>
        public EmbeddingMultiInputMetadata()
        {
        }
    }
}