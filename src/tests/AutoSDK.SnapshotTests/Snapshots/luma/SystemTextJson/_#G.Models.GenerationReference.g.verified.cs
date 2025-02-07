//HintName: G.Models.GenerationReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The generation reference object
    /// </summary>
    public sealed partial class GenerationReference
    {
        /// <summary>
        /// The ID of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Default Value: generation
        /// </summary>
        /// <default>global::G.GenerationReferenceType.Generation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GenerationReferenceTypeJsonConverter))]
        public global::G.GenerationReferenceType Type { get; set; } = global::G.GenerationReferenceType.Generation;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationReference" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the generation
        /// </param>
        /// <param name="type">
        /// Default Value: generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationReference(
            global::System.Guid id,
            global::G.GenerationReferenceType type = global::G.GenerationReferenceType.Generation)
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationReference" /> class.
        /// </summary>
        public GenerationReference()
        {
        }
    }
}