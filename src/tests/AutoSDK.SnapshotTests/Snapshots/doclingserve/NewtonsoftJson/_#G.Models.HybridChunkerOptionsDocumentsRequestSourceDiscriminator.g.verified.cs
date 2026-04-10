//HintName: G.Models.HybridChunkerOptionsDocumentsRequestSourceDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HybridChunkerOptionsDocumentsRequestSourceDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKindJsonConverter))]
        public global::G.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridChunkerOptionsDocumentsRequestSourceDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
        public HybridChunkerOptionsDocumentsRequestSourceDiscriminator(
            global::G.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridChunkerOptionsDocumentsRequestSourceDiscriminator" /> class.
        /// </summary>
        public HybridChunkerOptionsDocumentsRequestSourceDiscriminator()
        {
        }
    }
}