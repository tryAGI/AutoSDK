//HintName: G.Models.CitationStartEventDeltaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CitationStartEventDeltaMessage
    {
        /// <summary>
        /// Citation information containing sources and the text cited.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citations")]
        public global::G.Citation? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationStartEventDeltaMessage" /> class.
        /// </summary>
        /// <param name="citations">
        /// Citation information containing sources and the text cited.
        /// </param>
        public CitationStartEventDeltaMessage(
            global::G.Citation? citations)
        {
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationStartEventDeltaMessage" /> class.
        /// </summary>
        public CitationStartEventDeltaMessage()
        {
        }
    }
}