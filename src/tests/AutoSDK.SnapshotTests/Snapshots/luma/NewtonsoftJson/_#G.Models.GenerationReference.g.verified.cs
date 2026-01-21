//HintName: G.Models.GenerationReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The generation reference object<br/>
    /// Example: {"type":"generation","id":"123e4567-e89b-12d3-a456-426614174002"}
    /// </summary>
    public sealed partial class GenerationReference
    {
        /// <summary>
        /// Default Value: generation
        /// </summary>
        /// <default>global::G.GenerationReferenceType.Generation</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GenerationReferenceType Type { get; set; } = global::G.GenerationReferenceType.Generation;

        /// <summary>
        /// The ID of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationReference" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: generation
        /// </param>
        /// <param name="id">
        /// The ID of the generation
        /// </param>
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