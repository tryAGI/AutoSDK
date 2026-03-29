//HintName: G.Models.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKindJsonConverter))]
        public global::G.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminator(
            global::G.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminator" /> class.
        /// </summary>
        public HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminator()
        {
        }
    }
}