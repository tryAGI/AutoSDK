//HintName: G.Models.HybridChunkerOptionsDocumentsRequestTargetDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HybridChunkerOptionsDocumentsRequestTargetDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKindJsonConverter))]
        public global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridChunkerOptionsDocumentsRequestTargetDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
        public HybridChunkerOptionsDocumentsRequestTargetDiscriminator(
            global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridChunkerOptionsDocumentsRequestTargetDiscriminator" /> class.
        /// </summary>
        public HybridChunkerOptionsDocumentsRequestTargetDiscriminator()
        {
        }
    }
}