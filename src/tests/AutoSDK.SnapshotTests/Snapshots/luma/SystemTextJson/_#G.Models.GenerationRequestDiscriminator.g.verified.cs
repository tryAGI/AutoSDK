//HintName: G.Models.GenerationRequestDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GenerationRequestDiscriminatorGenerationTypeJsonConverter))]
        public global::G.GenerationRequestDiscriminatorGenerationType? GenerationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="generationType"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GenerationRequestDiscriminator(
            global::G.GenerationRequestDiscriminatorGenerationType? generationType)
        {
            this.GenerationType = generationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequestDiscriminator" /> class.
        /// </summary>
        public GenerationRequestDiscriminator()
        {
        }
    }
}