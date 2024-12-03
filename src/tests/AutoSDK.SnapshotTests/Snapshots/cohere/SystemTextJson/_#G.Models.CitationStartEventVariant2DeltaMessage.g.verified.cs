//HintName: G.Models.CitationStartEventVariant2DeltaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CitationStartEventVariant2DeltaMessage
    {
        /// <summary>
        /// Citation information containing sources and the text cited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::G.Citation? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationStartEventVariant2DeltaMessage" /> class.
        /// </summary>
        /// <param name="citations">
        /// Citation information containing sources and the text cited.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CitationStartEventVariant2DeltaMessage(
            global::G.Citation? citations)
        {
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationStartEventVariant2DeltaMessage" /> class.
        /// </summary>
        public CitationStartEventVariant2DeltaMessage()
        {
        }
    }
}