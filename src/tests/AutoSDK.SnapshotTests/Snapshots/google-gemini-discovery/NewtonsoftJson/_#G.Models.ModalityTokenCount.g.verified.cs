//HintName: G.Models.ModalityTokenCount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents token counting info for a single modality.
    /// </summary>
    public sealed partial class ModalityTokenCount
    {
        /// <summary>
        /// The modality associated with this token count.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modality")]
        public global::G.ModalityTokenCountModality? Modality { get; set; }

        /// <summary>
        /// Number of tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenCount")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModalityTokenCount" /> class.
        /// </summary>
        /// <param name="modality">
        /// The modality associated with this token count.
        /// </param>
        /// <param name="tokenCount">
        /// Number of tokens.
        /// </param>
        public ModalityTokenCount(
            global::G.ModalityTokenCountModality? modality,
            int? tokenCount)
        {
            this.Modality = modality;
            this.TokenCount = tokenCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModalityTokenCount" /> class.
        /// </summary>
        public ModalityTokenCount()
        {
        }
    }
}